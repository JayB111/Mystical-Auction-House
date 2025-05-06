import React, { useEffect, useState, useRef } from "react";
import axios from "axios";
import "./MysticalAuctionHouse.css";
import * as signalR from "@microsoft/signalr";

const coinSound = new Audio("/sounds/coin-sound.mp3");

function formatTimeLeft(endTime, now) {
  const end = new Date(endTime);
  const diff = Math.max(0, end - now);
  const mins = Math.floor(diff / 60000);
  const secs = Math.floor((diff % 60000) / 1000);
  return `${mins}m ${secs < 10 ? "0" : ""}${secs}s`;
}

export default function MysticalAuctionHouse() {
  const [products, setProducts] = useState([]);
  const [isAmbientPlaying, setIsAmbientPlaying] = useState(false);
  const [mythosBalance, setMythosBalance] = useState(1500);
  const [now, setNow] = useState(new Date());
  const ambientRef = useRef(null);

  useEffect(() => {
    const interval = setInterval(() => setNow(new Date()), 1000);
    return () => clearInterval(interval);
  }, []);

  useEffect(() => {
    axios.get("https://localhost:5001/api/products")
      .then(res => {
        const withFakeTimes = res.data.map(product => {
          const randomMinutes = Math.floor(Math.random() * 10) + 5;
          const fakeEnd = new Date(Date.now() + randomMinutes * 60000);
          return { ...product, fakeEndTime: fakeEnd };
        });
        setProducts(withFakeTimes);
      })
      .catch(err => console.error("Failed to load products", err));
  }, []);

  useEffect(() => {
    const connection = new signalR.HubConnectionBuilder()
      .withUrl("https://localhost:5001/bidhub")
      .withAutomaticReconnect()
      .build();

    connection.start()
      .then(() => {
        console.log("SignalR connected to bidhub");

        connection.on("BidPlaced", () => {
          console.log("BidPlaced received! Refreshing products...");
          axios.get("https://localhost:5001/api/products")
            .then(res => {
              const withFakeTimes = res.data.map(product => {
                const randomMinutes = Math.floor(Math.random() * 10) + 5;
                const fakeEnd = new Date(Date.now() + randomMinutes * 60000);
                return { ...product, fakeEndTime: fakeEnd };
              });
              setProducts(withFakeTimes);
            });
        });
      })
      .catch(err => console.error("SignalR connection failed:", err));

    return () => {
      connection.stop();
    };
  }, []);

  const handleBid = (id) => {
    coinSound.play();
    const item = products.find(p => p.id === id);
    const bidAmount = item ? Math.max(1, Math.floor(item.startingPrice * 0.1)) : 0;

    axios.put(`https://localhost:5001/api/products/${id}/bid`)
      .then(() => {
        setMythosBalance(prev => Math.max(0, prev - bidAmount));
        return axios.get("https://localhost:5001/api/products");
      })
      .then(res => {
        const withFakeTimes = res.data.map(product => {
          const randomMinutes = Math.floor(Math.random() * 10) + 5;
          const fakeEnd = new Date(Date.now() + randomMinutes * 60000);
          return { ...product, fakeEndTime: fakeEnd };
        });
        setProducts(withFakeTimes);
      })
      .catch(err => console.error("Bid failed:", err));
  };

  const toggleAmbient = () => {
    if (!ambientRef.current) return;

    if (isAmbientPlaying) {
      ambientRef.current.pause();
      setIsAmbientPlaying(false);
    } else {
      ambientRef.current.play().catch(err =>
        console.warn("Playback failed:", err)
      );
      setIsAmbientPlaying(true);
    }
  };

  return (
    <div className="auction-house">
      <div className="curtain-container">
        <div className="curtain left-curtain"></div>
        <div className="curtain right-curtain"></div>
      </div>

      <div className="sparkle-overlay"></div>

      <audio ref={ambientRef} src="/sounds/ambient-loop.mp3" loop />
      <button className="bid-button ambient-toggle" onClick={toggleAmbient}>
        {isAmbientPlaying ? "Pause Ambience" : "Play Ambience"}
      </button>

      <div className="mythos-counter">
        You have <span className="mythos-symbol">ɱ</span> {mythosBalance}
      </div>

      <header className="auction-header">
        <h1 className="glowing-title">Mystical Auction House</h1>
        <p className="intro">
          Step into the Mystical Auction House — where enchanted artifacts, divine relics, and ancient curses await new owners. Only those with courage and Mythos may claim the legends.
        </p>
        <p className="currency-note">
          All items are sold using <span className="mythos-symbol">ɱ</span> (Mythos), the currency of gods, spirits, and seekers of power.
        </p>
      </header>

      <div className="product-grid">
  {products.map(product => {
    const isAuctionEnded = new Date(product.fakeEndTime) - now <= 0;

    return (
      <div
        key={product.id}
        className={`auction-item ${
          [
            "The Coin of Forgotten Realms",
            "The Widow’s Veil",
            "The Lantern of the Deep Moon",
            "The Atlas of Lost Stars",
            "Tarot of the Veiled Realms",
            "The Thread of Tyron",
            "Zeus' Lightning Bolt",
            "True Love’s Kiss"
          ].includes(product.name) ? "glow" : ""
        }`}
      >
        <img src={`/images/${product.imageFileName}`} alt={product.name} />
        <h2>{product.name}</h2>
        <p>{product.description}</p>

        {isAuctionEnded ? (
          <p className="countdown relic-claimed">
          “This relic has been claimed by forces unseen.”
        </p>
        
        ) : (
          <p className="countdown">Ends in: {formatTimeLeft(product.fakeEndTime, now)}</p>
        )}

        <p className="price">
          Current bid: {product.currentPrice > 0 ? product.currentPrice : product.startingPrice}ɱ
        </p>

        <p className="bid-count">Total Bids: {product.bidCount}</p>

        {isAuctionEnded ? (
          <button className="bid-button disabled" disabled>
            Bidding Closed
          </button>
        ) : (
          <button className="bid-button" onClick={() => handleBid(product.id)}>
            Place Bid
          </button>
        )}
      </div>
    );
  })}
</div>

    </div>
  );
}
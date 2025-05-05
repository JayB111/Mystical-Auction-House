import { useEffect, useState } from "react";
import axios from "axios";
import './AuctionItems.css';

function formatTimeLeft(endTime, now) {
  const end = new Date(endTime);
  const diff = Math.max(0, end - now); // ms difference

  const mins = Math.floor(diff / 60000);
  const secs = Math.floor((diff % 60000) / 1000);
  return `${mins}m ${secs < 10 ? "0" : ""}${secs}s`;
}

function AuctionItems() {
  const [products, setProducts] = useState([]);
  const [now, setNow] = useState(new Date());

  // ⏱️ Update the clock every second
  useEffect(() => {
    const interval = setInterval(() => setNow(new Date()), 1000);
    return () => clearInterval(interval);
  }, []);

  // 🔁 Fetch products once
  useEffect(() => {
    axios
      .get("https://localhost:5001/api/products")
      .then((response) => setProducts(response.data))
      .catch((error) => console.error("Error fetching products:", error));
  }, []);

  return (
    <div className="auction-container">
      {products.map(product => (
        <div key={product.id} className="auction-card">
          <img src={`/images/${product.imageFileName}`} alt={product.name} />
          <h2>{product.name}</h2>
          <p>{product.description}</p>
          <p className="price">ɱ{product.startingPrice}</p>

          {/* ✅ Countdown displayed here */}
          <p className="countdown">
            Ends in: {formatTimeLeft(product.auctionEndTime, now)}
          </p>
        </div>
      ))}
    </div>
  );
}

export default AuctionItems;

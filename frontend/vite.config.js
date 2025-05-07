import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'
import mkcert from 'vite-plugin-mkcert'

export default defineConfig({
  base: '/Mystical-Auction-House/',
  plugins: [react(), mkcert()],
  server: {
    https: true,
    port: 5174, //lock to a known port
  }
})

import Menu from "./index";
import React from "react";
import "./index.css";

import { useState, useEffect } from 'react';
import axios from 'axios';

type Product = {
    id: number;
    name: string;
    price: number;
    imageUrl: string;
  };  

function App() {
    const [products, setProducts] = useState<Product[]>([]);

useEffect(() => {
  axios.get('https://localhost:7250/catalog', {
    headers: { 'Accept': 'application/json' }
  })
  .then(response => setProducts(response.data))
  .catch(error => console.error('Error fetching products:', error));
}, []);

    return (
        <div className="grid-container">
            <header>
                <h1>Welcome to Our Website</h1>
                <Menu />
            </header>
            <main>
                <p>This is a simple website structure.</p>
            </main>
            <footer>
                <p>© 2025 Operation Bus App Team 10 </p>
            </footer>
        </div>
    );
}

export default App;
import Payment from "./Payment/Payment";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";

function App() {
    return (
        <Router>
            <Routes>
                <Route path="/payment" element={<Payment />} />
            </Routes>
        </Router>
    );
}

export default App;
import { Link } from "react-router-dom";

const Menu = () => {
    return (
        <nav>
            <ul>
                <li><Link to="/">Home</Link></li>
                <li><Link to="/payment">Payment</Link></li>
            </ul>
        </nav>
    );
};

export default Menu;


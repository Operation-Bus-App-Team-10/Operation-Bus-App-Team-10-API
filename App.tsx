import React from "react";
import { BrowserRouter as Router, Route, Routes, Link } from "react-router-dom";
import Payment from "./Payment"; // Adjust if it's in a subfolder
import "./index.css";

// Inline Menu Component
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

// Inline Home Component
const Home = () => {
    return (
        <div>
            <h2>Welcome to the Home Page</h2>
            <p>This is the homepage of the app.</p>
        </div>
    );
};

function App() {
    return (
        <Router>
            <Menu />
            <Routes>
                <Route path="/" element={<Home />} />
                <Route path="/payment" element={<Payment />} />
            </Routes>
        </Router>
    );
}

export default App;

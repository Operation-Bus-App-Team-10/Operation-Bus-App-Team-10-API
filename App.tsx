import Menu from "./index";
import React from "react";
import "./index.css";

function App() {
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


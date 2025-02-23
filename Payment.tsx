import React, { useState } from "react";
import CheckoutSteps from "./CheckoutSteps";

const Payment: React.FC = () => {
    const [cardNumber, setCardNumber] = useState("");
    const [expiryDate, setExpiryDate] = useState("");
    const [cvv, setCvv] = useState("");

    const submitHandler = (e: React.FormEvent) => {
        e.preventDefault();
        alert("Payment successful!");
    };

    return (
        <div>
            <CheckoutSteps step1 step2 step3 />
            <h2>Payment Details</h2>
            <form onSubmit={submitHandler}>
                <div>
                    <label>Card Number</label>
                    <input
                        type="text"
                        value={cardNumber}
                        onChange={(e) => setCardNumber(e.target.value)}
                        placeholder="1234 5678 9101 1121"
                        required
                    />
                </div>

                <div>
                    <label>Expiry Date</label>
                    <input
                        type="text"
                        value={expiryDate}
                        onChange={(e) => setExpiryDate(e.target.value)}
                        placeholder="MM/YY"
                        required
                    />
                </div>

                <div>
                    <label>CVV</label>
                    <input
                        type="text"
                        value={cvv}
                        onChange={(e) => setCvv(e.target.value)}
                        placeholder="123"
                        required
                    />
                </div>

                <button type="submit">Submit Payment</button>
            </form>
        </div>
    );
};

export default Payment;

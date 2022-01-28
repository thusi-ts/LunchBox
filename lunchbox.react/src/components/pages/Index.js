import React, { Component } from 'react'
import ProductList from "../ProductList";
import Cart from "../Cart";

export default class Index extends Component {
    render() {
        return (
            <div>
                <div className="main-header">Kylling & Co Viborg, Gravene</div>
                <div className="main-inner-wrapper">
                    <div className="main">
                    <ProductList />
                    </div>
                    <div className="cart">
                    <Cart />
                    </div>
                </div>
            </div>
        )
    }
}
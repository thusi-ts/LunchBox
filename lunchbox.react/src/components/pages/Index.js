import React, { Component } from 'react'
import ProductList from "/components/ProductList";
import Cart from "/components/Cart";

export default class Index extends Component {
    render() {
        return (
            <div>
                <div className="main-header">Kylling & Co Viborg, Gravene</div>
                <div className="main-inner-wrapper">
                    <div class="main">
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
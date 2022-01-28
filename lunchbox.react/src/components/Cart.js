import React, { Component } from 'react'

export default class Cart extends Component {
    render() {
        return (
            <div>
                <div className="main-title">Bestillinge</div>
                <ul className="product-list-wrapper">
                    <li className="product-list item">
                        <span className="name"><span className="quantity-holder "> 1 </span> x kylling &amp; Annanas</span>
                        <span className="price">33 kr.</span>
                        <span className="sign minus">-</span>
                        <span className="sign plus">+</span>
                    </li>
                    <li className="product-list item">
                        <span className="name">Kylling &amp; Jalepenos</span>
                        <span className="price">43 kr.</span>
                        <span className="sign minus">-</span>
                        <span className="sign plus">+</span>
                    </li>
                    <li className="product-list item">
                        <span className="name">Laks</span>
                        <span className="price">43 kr.</span>
                        <span className="sign minus">-</span>
                        <span className="sign plus">+</span>
                    </li>
                </ul>
            </div>
        )
    }
}
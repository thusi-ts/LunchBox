import React, { Component } from 'react'

export default class ProductList extends Component {
    render() {
        return (
            <div>
                
                <div className="main-title">Menukort</div>
            
                <ul className="product-list-wrapper">
                    <li className="product-list header">
                        <span class="icon"><img src="http://www.lunchbox.dk/assets/images/product/kc.jpg" className="product-list-icon" alt="" border="0"></img></span>
                        <span>Sandwich</span>
                    </li>
                    <li className="product-list item">
                        <span className="name">kylling</span>
                        <span className="price">28 kr.</span>
                    </li>
                    <li className="product-list item">
                        <span className="name">kylling &amp; Bacon</span>
                        <span className="price">28 kr.</span>
                    </li>
                    <li className="product-list item">
                        <span className="name">Kylling &amp; Annanas</span>
                        <span className="price">28 kr.</span>
                    </li>
                    <li className="product-list item">
                        <span className="name">Kylling &amp; Jalepenos</span>
                        <span className="price">28 kr.</span>
                    </li>
                </ul>
            </div>
        )
    }
}
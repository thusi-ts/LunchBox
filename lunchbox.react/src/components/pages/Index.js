import React, { Component } from 'react'
import ImageSlider from "../ImageSlider";
import StoreList from "../StoreList";

export default class Index extends Component {
    render() {
        return (
            <div className="slider-wrapper">
                <div className="main-header">Kylling & Co Viborg, Gravene</div>
                <div className="main-resume">
                    Har du eller dit firma har brug for noget rigtig lækkert til frokost, som er godt for krop og sjæl, er du kommer til det helt rigtig sted. Vælg fra listen neden under hvor du gerne ville have det fra.
                </div>
                <ImageSlider />
                <StoreList />
            </div>
        )
    }
}
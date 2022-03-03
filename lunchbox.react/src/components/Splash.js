import React, { Component } from 'react'

export default class Splash extends Component {
    render() {
        return (
            <div className="header-wrapper">
                <div className="bg-left main-index"></div>
                <div className="bg-right main-index"></div>
            
                <div data-role="main" className="splash-content splash-content-cbox" id="splash-content">
                    <div class="logo">
                        <img src="http://www.lunchbox.dk/assets/images/logo/white.svg" alt="" className="default-icon" border="0" /> 
                    </div>
                    <div className="green-bar">
                        <div className="loader"></div>                
                    </div> 
                </div>
            </div>
        )
    }
}
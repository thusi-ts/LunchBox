import React, { Component } from 'react'

export default class Splash extends Component {
    render() {
        return (
            <div className="header-wrapper">
                <div className="back">Back</div>
                <div className="logo">
                    <img src="http://www.lunchbox.dk/assets/images/logo/white.svg" onclick="link_navigation('index');" class="default-icon" alt="" border="0"></img>
                </div>
                <div className="memebership"><i className="fa fa-user"></i><a href="#">Login som medlem</a></div>
            </div>
        )
    }
}
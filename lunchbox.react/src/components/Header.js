import React, { Component } from 'react'
import { Link } from 'react-router-dom';

import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faCoffee  } from '@fortawesome/free-solid-svg-icons'

const myfood = <FontAwesomeIcon icon={faCoffee} style={{ color: 'white' }} />

export default class Header extends Component {
    render() {
        return (
            <div className="header-wrapper">
                <div className="back">Back</div>
                <div className="logo">
                <Link to="/pages"><img src="http://www.lunchbox.dk/assets/images/logo/white.svg" className="default-icon" alt="" border="0" /></Link>
                </div>
                <div className="memebership">{myfood} <Link to="/pages/login">Login som medlem</Link></div>
            </div>
        )
    }
}

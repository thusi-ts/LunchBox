import React, { Component } from 'react'
import { Navigate } from 'react-router';

export default class Splash extends Component {
    render() {
        return (
            <div className="header-wrapper">{this.props.currentPath}
                <div className="bg-left main-index"></div>
                <div className="bg-right main-index"></div>
            
                <div data-role="main" className="ui-content ui-content-cbox" id="splash-content">
                    <div className="logo">
                        <img src="http://www.lunchbox.dk/assets/images/logo/white.svg" alt="white" className="default-icon" border="0" /> 
                    </div>
                    <div className="green-bar">
                        <div className="loader"></div>                
                    </div> 
                </div>
            </div>
        )
    }

    componentDidUpdate() { console.log('0');
        setTimeout(() => { 
            console.log('test');
            <Navigate to='/pages'  />
          }, 5000)
      }
      
}
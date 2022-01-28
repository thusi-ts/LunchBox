import React, { Component } from 'react'

export default class ForgotPassword extends Component {
    render() {
        return (
            <div>
                <h1>Glemt password</h1>
                <form id="user-forgot-password-form" method="post">
                
                <p className="row">
                    <label for="email" className="labeltxt">E-mail: ( bruges til brugernavn )</label>
                    <input type="email" className="inputC" name="forgot_mail" required="" />
                </p>
                
                <p className="row">
                    <input className="submit button user-forgot-password-submit-button" type="submit" value="Send" />
                </p>
                <input type="hidden" name="x_login_submit" value="1" />
                </form>
            </div>
        )
    }
}
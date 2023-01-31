import React, { useEffect } from 'react'
import PropTypes from 'prop-types'
import { useNavigate } from 'react-router'
import { useAuth } from '../contexts/auth';

const Home = props => {
    const navigate = useNavigate();
    const Auth = useAuth();
    useEffect(() => {
        if(Auth.authState.username) {
            navigate("/books")
        }
    },[Auth.authState]);
    
    return (
        <div className="d-flex justify-content-center align-items-center" style={{minHeight: "90vh"}}>
            <div id="login-card" className="card" onClick={() => navigate("/login")}>
              <div className="card-body">
                <h4 className="card-title">Login</h4>
              </div>
            </div>
            <div id="register-card" className="card" onClick={() => navigate("/signup")}>
              <div className="card-body">
                <h4 className="card-title">Signup</h4>
              </div>
            </div>
        </div>
    )
}

Home.propTypes = {}

export default Home
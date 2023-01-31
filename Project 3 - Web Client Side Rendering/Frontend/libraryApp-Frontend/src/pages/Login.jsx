import React, { useState } from 'react'
import PropTypes from 'prop-types'
import { useAuth } from '../contexts/auth';
import { useNavigate } from 'react-router';

const Login = props => {
  const [message, setMessage] = useState(null);
  const Auth = useAuth();
  const navigate = useNavigate();
  const onSubmit = (event) => {
    event.preventDefault();
    const username = event.target[0].value;
    const password = event.target[1].value;
    const logged = Auth.login(username, password);
    if (logged) {
      navigate("/books");
      return;
    }

    setMessage("Error: Wrong username/password!");
  };

  return (
    <div className="d-flex flex-wrap justify-content-center align-items-center" style={{ minHeight: "90vh", width: "100%" }}>
      <form className="d-flex row flex-wrap justify-content-center align-items-center" style={{ backgroundColor: "#FFFFFF70", borderRadius:"0.5rem", height: "20rem", width:"30rem", border:"1px solid #0000000F"}}  onSubmit={onSubmit}>
        <div className="d-flex row" style={{ height: "70%", justifyContent:"center", alignItems:"space-between"}} >
          <div className="d-flex row justify-content-center align-items-center">
            <label for="" className="form-label" style={{marginBottom: "-1rem"}}>Username</label>
            <input type="text"
              className="form-control" name="" id="" aria-describedby="helpId" placeholder="" />
          </div>
          <div className="d-flex row justify-content-center align-items-center">
            <label for="" className="form-label" style={{marginBottom: "-1rem"}}>Password</label>
            <input type="password"
              className="form-control" name="" id="" aria-describedby="helpId" placeholder="" />
          </div>
        </div>
        <div class="d-grid gap-2">
          <button type="submit" name="" id="" class="btn" style={{ backgroundColor: "#34495e", color: "white" }}>Login</button>
        </div>
        <small class="form-text text-muted text-center" style={{color: "red"}}>{message}</small>
      </form>
    </div>
  )
}

Login.propTypes = {}

export default Login
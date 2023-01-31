import React, { useState } from 'react'
import PropTypes from 'prop-types'
import { useAuth } from '../contexts/auth';
import { useNavigate } from 'react-router';

const Register = props => {
  const [message, setMessage] = useState(null);
  const Auth = useAuth();
  const navigate = useNavigate();

  const onSubmit = (event) => {
    event.preventDefault();
    const username = event.target[0].value;
    const password = event.target[1].value;

    if(!username || !password){
      setMessage("Error: Insert username and password!");
    }

    const logged = Auth.login(username, password);
    console.log("Logged:",logged)
    if (logged) {
      navigate("/books");
      return;
    }

  };

  return (
    <div className="d-flex flex-wrap justify-content-center align-items-center" style={{ minHeight: "90vh", width: "100%" }}>
      <form className="d-flex row flex-wrap justify-content-center align-items-center" style={{ backgroundColor: "#FFFFFF70", borderRadius:"0.5rem", height: "25rem", width:"30rem", border:"1px solid #0000000F"}}  onSubmit={onSubmit}>
        <div className="d-flex row" style={{ height: "70%", justifyContent:"center", alignItems:"space-between"}} >
          <div className="d-flex row justify-content-center align-items-center">
            <label for="" className="form-label mb-0" style={{marginBottom: "-1rem"}}>Username</label>
            <input type="text"
              className="form-control" name="" id="" aria-describedby="helpId" placeholder="" />
            <small id="helpId" class="form-text text-muted" style={{marginTop: "-1rem"}}>Insert your username</small>
          </div>
          <div className="d-flex row justify-content-center align-items-center" >
            <label for="" className="form-label mb-0" style={{marginBottom: "-1rem"}}>Password</label>
            <input type="password" className="form-control mt-0 mb-0"  name="" aria-describedby="helpId" placeholder="" />
            <small id="helpId" style={{marginTop: "-1rem"}} class="form-text text-muted">Insert your password</small>
          </div>
        </div>
        <div class="d-grid gap-4" style={{margin: "0px 1rem"}}>
          <button type="submit" name="" id="" class="btn" style={{ backgroundColor: "#34495e", color: "white" }}>Signup</button>
        </div>
        <small class="form-text text-muted text-center" style={{color: "red"}}>{message}</small>
      </form>
    </div>
  )
}

Register.propTypes = {}

export default Register
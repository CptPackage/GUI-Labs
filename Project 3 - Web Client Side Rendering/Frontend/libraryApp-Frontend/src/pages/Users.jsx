import React from 'react'
import PropTypes from 'prop-types'
import { useProtectedRoute } from '../contexts/auth';

const Users = props => {
    useProtectedRoute();
    return (
        <div className="d-flex justify-content-center align-items-center flex-wrap" style={{ minHeight: "90vh" }}>
            <table className="table table-dark table-striped text-center" style={{ width: "50%" }}>
                <thead style={{ height: "2rem" }}>
                    <tr style={{ minWidth: "100%" }}>
                        <th>Users</th>
                    </tr>
                </thead>
                <thead style={{ height: "2rem" }}>
                    <tr>
                        <th>#</th>
                        <th>Username</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th>1</th>
                        <th>librerian</th>
                    </tr>
                    <tr>
                        <th>2</th>
                        <th>jeremy</th>
                    </tr>
                    <tr>
                        <th>3</th>
                        <th>james</th>
                    </tr>
                    <tr>
                        <th>4</th>
                        <th>richard</th>
                    </tr>
                </tbody>
            </table>
        </div>
    )
}

Users.propTypes = {}

export default Users
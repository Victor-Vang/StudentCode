<template>
  <table id="tblUsers">
    <thead>
      <tr>
        <th>First Name</th>
        <th>Last Name</th>
        <th>Username</th>
        <th>Email Address</th>
        <th>Status</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td>
          <input type="text" id="firstNameFilter" v-model="filter.firstName" />
        </td>
        <td>
          <input type="text" id="lastNameFilter" v-model="filter.lastName" />
        </td>
        <td>
          <input type="text" id="usernameFilter" v-model="filter.username" />
        </td>
        <td>
          <input type="text" id="emailFilter" v-model="filter.emailAddress" />
        </td>
        <td>
          <select id="statusFilter" v-model="filter.status">
            <option value="">Show All</option>
            <option value="Active">Active</option>
            <option value="Disabled">Disabled</option>
          </select>
        </td>
      </tr>
      <!-- user listing goes here -->
      <tr class="user" v-bind:class="{'disabled': user.status === 'Disabled'}" v-for="user in filteredList" v-bind:key="user.firstName">
        <td>
          <h4>{{ user.firstName }}</h4>
        </td>
        <td>
          <h4>{{ user.lastName }}</h4>
        </td>
        <td>
          <h4>{{ user.username }}</h4>
        </td>
        <td>
          <h4>{{ user.emailAddress }}</h4>
        </td>
        <td>
          <h4>{{ user.status }}</h4>
        </td>
      </tr>
    </tbody>
  </table>
</template>

<script>
export default {
  name: "user-list",
  data() {
    return {
      users: [
        {
          firstName: "John",
          lastName: "Smith",
          username: "jsmith",
          emailAddress: "jsmith@gmail.com",
          status: "Active",
        },
        {
          firstName: "Anna",
          lastName: "Bell",
          username: "abell",
          emailAddress: "abell@yahoo.com",
          status: "Active",
        },
        {
          firstName: "George",
          lastName: "Best",
          username: "gbest",
          emailAddress: "gbest@gmail.com",
          status: "Disabled",
        },
        {
          firstName: "Ben",
          lastName: "Carter",
          username: "bcarter",
          emailAddress: "bcarter@gmail.com",
          status: "Active",
        },
        {
          firstName: "Katie",
          lastName: "Jackson",
          username: "kjackson",
          emailAddress: "kjackson@yahoo.com",
          status: "Active",
        },
        {
          firstName: "Mark",
          lastName: "Smith",
          username: "msmith",
          emailAddress: "msmith@foo.com",
          status: "Disabled",
        },
      ],
      filter: {
        firstName: "",
        lastName: "",
        username: "",
        emailAddress: "",
        status: "",
      },
    };
  },
  computed: {
    filteredList() {
      let result = this.users;
            if (this.filter)
              {
              result = result.filter( (x) =>
              x.firstName.toLowerCase().includes(this.filter.firstName.toLowerCase()));
              result = result.filter( (x) =>
              x.lastName.toLowerCase().includes(this.filter.lastName.toLowerCase()));
              result = result.filter( (x) =>
              x.username.toLowerCase().includes(this.filter.username.toLowerCase()));
              result = result.filter( (x) =>
              x.emailAddress.toLowerCase().includes(this.filter.emailAddress.toLowerCase()));
              result = result.filter( (x) =>
              x.status.includes(this.filter.status));
            }
          return result;
    }
    },
  };
    // filteredList() {
    //   let filteredUsers = this.users;
      // if (this.filter) {
      //   filteredUsers = filteredUsers.filter((user) => {
      //     user.firstName
      //       .toLowerCase()
      //       .includes(this.filter.firstName.toLowerCase());
      //   });
      //   filteredUsers = filteredUsers.filter((user) => {
      //     user.lastName
      //       .toLowerCase()
      //       .includes(this.filter.lastName.toLowerCase());
      //   });

      //   filteredUsers = filteredUsers.filter((user) => {
      //     user.username
      //       .toLowerCase()
      //       .includes(this.filter.username.toLowerCase());
      //   });
      //   filteredUsers = filteredUsers.filter((user) => {
      //     user.emailAddress
      //       .toLowerCase()
      //       .includes(this.filter.emailAddress.toLowerCase());
      //   });
      //   filteredUsers = filteredUsers.filter((user) => {
      //     user.status === this.filter.status;
      //   });
      // }
      // return filteredUsers;
</script>

<style scoped>
table {
  margin-top: 20px;
  font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, Oxygen,
    Ubuntu, Cantarell, "Open Sans", "Helvetica Neue", sans-serif;
}
th {
  text-transform: uppercase;
}
td {
  padding: 10px;
}
tr.disabled {
  color: red;
}
input,
select {
  font-size: 16px;
}
</style>

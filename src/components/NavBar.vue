<template>
  <nav class="navbar navbar-expand-lg bg-body-tertiary">
    <div class="container-fluid">
      <router-link class="navbar-brand" :to="{ name: '404' }"
        >Navbar</router-link
      >
      <button
        class="navbar-toggler"
        type="button"
        data-bs-toggle="collapse"
        data-bs-target="#navbarSupportedContent"
        aria-controls="navbarSupportedContent"
        aria-expanded="false"
        aria-label="Toggle navigation"
      >
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarSupportedContent">
        <ul class="navbar-nav me-auto mb-2 mb-lg-0">
          <li class="nav-item">
            <router-link
              class="nav-link active"
              aria-current="page"
              :to="{ name: 'home' }"
              >Home</router-link
            >
          </li>
          <li class="nav-item">
            <router-link class="nav-link" :to="{ name: 'link' }"
              >Link</router-link
            >
          </li>
          <li class="nav-item dropdown">
            <a
              class="nav-link dropdown-toggle"
              href="#"
              role="button"
              data-bs-toggle="dropdown"
              aria-expanded="false"
            >
              Dropdown
            </a>
            <ul class="dropdown-menu">
              <li>
                <router-link class="dropdown-item" :to="{ name: 'action' }"
                  >Action</router-link
                >
              </li>
              <li>
                <router-link
                  class="dropdown-item"
                  :to="{ name: 'anotherAction' }"
                  >Another action</router-link
                >
              </li>
              <li>
                <hr class="dropdown-divider" />
              </li>
              <li>
                <router-link class="dropdown-item" :to="{ name: 'sthElse' }"
                  >Something else here</router-link
                >
              </li>
            </ul>
          </li>
          <li class="nav-item">
            <a class="nav-link disabled">Disabled</a>
          </li>
          <!--前后端通信测试页面-->
          <li class="nav-item">
            <router-link class="nav-link" :to="{ name: 'test' }"
              >前后端测试页面</router-link
            >
          </li>
        </ul>
        <form class="d-flex" role="search">
          <input
            class="form-control me-2"
            type="search"
            placeholder="Search"
            aria-label="Search"
          />
          <button class="btn btn-outline-success" type="submit">Search</button>
        </form>
        <button
          type="button"
          class="btn btn-outline-dark"
          data-bs-toggle="modal"
          data-bs-target="#exampleModal"
          data-bs-whatever="@mdo"
        >
          Login
        </button>
        <div
          class="modal fade"
          id="exampleModal"
          tabindex="-1"
          aria-labelledby="exampleModalLabel"
          aria-hidden="true"
        >
          <div class="modal-dialog">
            <div class="modal-content">
              <div class="modal-header">
                <h1 class="modal-title fs-5" id="exampleModalLabel">
                  LoginPage
                </h1>
                <button
                  type="button"
                  class="btn-close"
                  data-bs-dismiss="modal"
                  aria-label="Close"
                ></button>
              </div>
              <div class="modal-body">
                <form>
                  <div class="mb-3">
                    <label for="recipient-name" class="col-form-label"
                      >EmailAdrr:</label
                    >
                    <!--input中双向绑定处理数据-->
                    <input
                      type="text"
                      class="form-control"
                      v-model="emailadrr"
                      ref="email_input"
                    />
                  </div>
                  <div class="mb-3">
                    <label for="message-text" class="col-form-label"
                      >PassWord:</label
                    >
                    <input
                      type="text"
                      class="form-control"
                      v-model="password"
                      ref="password_input"
                    />
                  </div>
                </form>
              </div>
              <div class="modal-footer">
                <button
                  type="button"
                  class="btn btn-secondary"
                  data-bs-dismiss="modal"
                >
                  Close
                </button>
                <button type="button" class="btn btn-primary" @click="login">
                  Login
                </button>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </nav>
</template>

<script>
import API from "../api/loginTest.js";

export default {
  name: "NavBar",
  data() {
    return {
      //通过v-model实现前端数据绑定,该页面组件获取数据返回
      emailadrr: "",
      password: "",
    };
  },
  methods: {
    login() {
      //获取用户在前端的输入，这里可以前端判断和后端接口调用
      const _emailadrr = this.$refs.email_input.value;
      const _password = this.$refs.password_input.value;

      console.log(_emailadrr + "  " + this.emailadrr);
      console.log(_password + "  " + this.password);
      //这里写前端可以进行的判断，包括格式控制等

      //这里写后端接口调用检查用户是否注册能够登录
      console.log("登录请求测试！");
      API({
        url: "/HelloWorld/GetParams",
        method: "get",
        params: {
          num: 123,
          str: " Test of params",
        },
      }).then(
        function (res) {
          alert("请求成功!");
          console.log(res);
        },
        function (err) {
          console.log(err);
        }
      );
    },
  },
};
</script>

<style scoped></style>
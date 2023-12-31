import { createRouter, createWebHashHistory } from 'vue-router'

import HomeView from '../views/HomeView.vue'
import NotFoundView from '../views/NotFoundView.vue'
import LinkView from '../views/LinkView.vue'
import ActionView from '../views/ActionView.vue'
import AnotherActionView from '../views/AnotherActionView.vue'
import SthElseView from '../views/SthElseView.vue'
import TestView from '../views/TestView.vue' //导入测试文件

const routes = [
  {
    path: '/',
    name: 'home',
    component: HomeView
  },
  {
    path: '/link',
    name: 'link',
    component: LinkView
  },
  {
    path: '/action',
    name: 'action',
    component: ActionView
  },
  {
    path: '/anotherAction',
    name: 'anotherAction',
    component: AnotherActionView
  },
  {
    path: '/sthElse',
    name: 'sthElse',
    component: SthElseView
  },
  {
    path: '/404',
    name: '404',
    component: NotFoundView
  },
  {
    path: '/test',
    name: 'test',
    component: TestView //测试文件的路由
  },
]

const router = createRouter({
  history: createWebHashHistory(),
  routes
})

export default router

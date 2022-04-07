import Vue from 'vue';
import VueRouter from 'vue-router';
import Home from '@/views/Home.vue';
import MyBooks from '@/views/MyBooks.vue';
import NewBook from '@/views/NewBook.vue';
import DetailsOfBook from '@/views/DetailsOfBook.vue';

Vue.use(VueRouter);

const routes = [
{
  path: '/',
  name: 'Home',
  component: Home
},
{
  path: '/myBooks',
  name: 'MyBooks',
  component: MyBooks
},
{
  path: '/addBook',
  name: 'NewBook',
  component: NewBook
},
{
  path: '/book/:isbn',
  name: 'DetailsOfBook',
  component: DetailsOfBook
},
];

const router = new VueRouter({
  mode: 'history',
  routes
});

export default router;

import { Routes, RouterModule, RouterConfig } from '@angular/router';
import { AppComponent } from './app.component';
import { BlogService } from './blog/blog.service';
import { BlogList } from './blog/blog-list/blog.list';
import { BlogDetails } from './blog/blog-details/blog.details';
import { BlogAdd } from './blog/blog-add/blog.add';
import { BlogDelete } from './blog/blog-delete/blog.delete';
import { BlogEdit } from './blog/blog-edit/blog.edit';


const appRoutes: Routes = [
    { path: '', component: BlogList },
    { path: 'detail/:id', component: BlogDetails },
    { path: 'edit/:id', component: BlogEdit },
    { path: 'delete/:id', component: BlogDelete },
    { path: 'add', component: BlogAdd }

]; export const routing = RouterModule.forRoot(appRoutes);

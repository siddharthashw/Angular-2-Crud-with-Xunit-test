import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent }  from './app.component';
import { BlogService }  from './blog/blog.service';
import { BlogList }  from './blog/blog-list/blog.list';
import { routing } from './app.routes';
import { HttpModule } from '@angular/http';
import { FormsModule }   from '@angular/forms';
import { BlogDetails } from './blog/blog-details/blog.details';
import { HttpService }  from './http.service';
import { BlogAdd } from './blog/blog-add/blog.add';
import { BlogDelete } from './blog/blog-delete/blog.delete';
import { BlogEdit } from './blog/blog-edit/blog.edit';



@NgModule({
    imports: [BrowserModule, routing, FormsModule, HttpModule],
    declarations: [AppComponent, BlogList, BlogDetails, BlogAdd, BlogDelete, BlogEdit],
    bootstrap: [AppComponent],
    providers: [HttpService, BlogService]
})
export class AppModule { }

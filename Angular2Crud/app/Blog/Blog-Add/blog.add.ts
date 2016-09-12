import { Component, OnInit } from '@angular/core';
import { BlogService } from '../blog.service';
import { Blog }  from '../blog';
import { Router, ROUTER_DIRECTIVES, ActivatedRoute }from '@angular/router';
import {Location} from "@angular/common";

@Component({
    selector: 'my-app',
    templateUrl: './app/Blog/Blog-Add/blog-add.html',
})
export class BlogAdd {
    blogs: any;
    blog: Blog = new Blog();
    constructor(private http: BlogService, private router: Router, private location: Location) { }

    addBlog(blog: any) {
        this.http.AddBlog(blog).subscribe((result: any) => {
            this.blogs = result;
            this.router.navigate(['']);
        })
    }

    goBack() {
        this.location.back();
    }
}

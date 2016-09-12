import { Component, OnInit } from '@angular/core';
import { BlogService } from '../blog.service';
import { Blog }  from '../blog';
import { Router, ROUTER_DIRECTIVES, ActivatedRoute }from '@angular/router';

@Component({
    selector: 'my-app',
    templateUrl:'./app/Blog/Blog-List/blog-list.html',
})
export class BlogList implements OnInit {
    blogs: Array<Blog>;
    constructor(private http: BlogService, private router: Router) { }
    ngOnInit() {
        this.getAllBlog();
    }

    getAllBlog() {
        this.http.getAll().subscribe((result: any) => {
            this.blogs = result;
        });
    }
}

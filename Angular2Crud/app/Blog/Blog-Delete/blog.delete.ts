import { Component, OnInit } from '@angular/core';
import { BlogService } from '../blog.service';
import { Blog }  from '../blog';
import { Router, ROUTER_DIRECTIVES, ActivatedRoute }from '@angular/router';
import {Location} from "@angular/common";

@Component({
    selector: 'my-app',
    templateUrl: './app/Blog/Blog-Delete/blog-delete.html',
})
export class BlogDelete implements OnInit {
    blogs = new Blog;
    id: any;
    constructor(private http: BlogService, private route: ActivatedRoute, private router: Router, private location: Location) { }
    ngOnInit() {
        this.getBlog();
    }

    getBlog() {
        this.id = this.route.params.subscribe(params => {
            let id = this.route.snapshot.params['id'];
            this.http.getById(id).subscribe((result: any) => {
                this.blogs = result;
            })
        })
    }

    deleteBlog(id: any) {
        this.http.DeleteBlog(id).subscribe((result: any) => {
            this.router.navigate(['']);
        })
    }
    goBack() {
        this.location.back();
    }
}

@model IEnumerable<flightmvc.Models.flightmodel>

@{
    ViewBag.Title = "Listflight";
    Layout = "~/Views/Shared/_Layout.cshtml";
}

<h2>Listflight</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(model => model.flightid)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.flightname)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.flightarrival)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.flightdeparture)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.passengercnt)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.captainid)
        </th>
        <th></th>
    </tr>

@foreach (var item in Model) {
    <tr>
        <td>
            @Html.DisplayFor(modelItem => item.flightid)
        </td>
        <td>
            @Html.DisplayFor(modelItem => item.flightname)
        </td>
        <td>
            @Html.DisplayFor(modelItem => item.flightarrival)
        </td>
        <td>
            @Html.DisplayFor(modelItem => item.flightdeparture)
        </td>
        <td>
            @Html.DisplayFor(modelItem => item.passengercnt)
        </td>
        <td>
            @Html.DisplayFor(modelItem => item.captainid)
        </td>
        <td>
            @Html.ActionLink("Edit", "updateflight", new {  id=item.flightid }) |
            @Html.ActionLink("Details", "details", new { id=item.flightid }) |
            @Html.ActionLink("Delete", "cancelflight", new {  id=item.flightid})
        </td>
    </tr>
}

</table>

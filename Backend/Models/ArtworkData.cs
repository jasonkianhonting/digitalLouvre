using System.Text.Json.Serialization;

namespace Backend.Models;

public class ArtworkData
{
    
    [JsonPropertyName("id")] public int Id { get; init; }
    
    [JsonPropertyName("title")] public string? Title { get; init; }

    [JsonPropertyName("thumbnail")] public Thumbnail? Thumbnail { get; init; }
    
    [JsonPropertyName("date_start")] public int? DateStart { get; init; }

    [JsonPropertyName("date_end")] public int? DateEnd { get; init; }

    [JsonPropertyName("date_display")] public string? DateDisplay { get; init; }
    
    [JsonPropertyName("artist_display")] public string? ArtistDisplay { get; init; }

    [JsonPropertyName("place_of_origin")] public string? PlaceOfOrigin { get; init; }

    [JsonPropertyName("description")] public object? Description { get; init; }

    [JsonPropertyName("short_description")]
    public object? ShortDescription { get; init; }

    [JsonPropertyName("dimensions")] public string? Dimensions { get; init; }

    [JsonPropertyName("dimensions_detail")]
    public List<DimensionsDetail>? DimensionsDetail { get; init; }

    [JsonPropertyName("medium_display")] public string? MediumDisplay { get; init; }

    [JsonPropertyName("inscriptions")] public object? Inscriptions { get; init; }

    [JsonPropertyName("credit_line")] public string? CreditLine { get; init; }

    [JsonPropertyName("catalogue_display")]
    public string? CatalogueDisplay { get; init; }

    [JsonPropertyName("publication_history")]
    public object? PublicationHistory { get; init; }

    [JsonPropertyName("exhibition_history")]
    public object? ExhibitionHistory { get; init; }

    [JsonPropertyName("provenance_text")] public object? ProvenanceText { get; init; }

    [JsonPropertyName("edition")] public object? Edition { get; init; }

    [JsonPropertyName("publishing_verification_level")]
    public string? PublishingVerificationLevel { get; init; }

    [JsonPropertyName("internal_department_id")]
    public int? InternalDepartmentId { get; init; }

    [JsonPropertyName("fiscal_year")] public object? FiscalYear { get; init; }

    [JsonPropertyName("fiscal_year_deaccession")]
    public object? FiscalYearDeaccession { get; init; }

    [JsonPropertyName("is_public_domain")] public bool? IsPublicDomain { get; init; }

    [JsonPropertyName("is_zoomable")] public bool? IsZoomable { get; init; }

    [JsonPropertyName("max_zoom_window_size")]
    public int? MaxZoomWindowSize { get; init; }

    [JsonPropertyName("copyright_notice")] public object? CopyrightNotice { get; init; }
    
    [JsonPropertyName("latlon")] public object? Latlon { get; init; }

    [JsonPropertyName("is_on_view")] public bool? IsOnView { get; init; }

    [JsonPropertyName("on_loan_display")] public object? OnLoanDisplay { get; init; }

    [JsonPropertyName("gallery_title")] public object? GalleryTitle { get; init; }

    [JsonPropertyName("gallery_id")] public object? GalleryId { get; init; }

    [JsonPropertyName("nomisma_id")] public object? NomismaId { get; init; }

    [JsonPropertyName("artwork_type_title")]
    public string? ArtworkTypeTitle { get; init; }

    [JsonPropertyName("artwork_type_id")] public int? ArtworkTypeId { get; init; }

    [JsonPropertyName("department_title")] public string? DepartmentTitle { get; init; }

    [JsonPropertyName("department_id")] public string? DepartmentId { get; init; }

    [JsonPropertyName("artist_id")] public int? ArtistId { get; init; }

    [JsonPropertyName("artist_title")] public string? ArtistTitle { get; init; }

    [JsonPropertyName("alt_artist_ids")] public List<object>? AltArtistIds { get; init; }

    [JsonPropertyName("artist_ids")] public List<int>? ArtistIds { get; init; }

    [JsonPropertyName("artist_titles")] public List<string>? ArtistTitles { get; init; }

    [JsonPropertyName("category_ids")] public List<string>? CategoryIds { get; init; }

    [JsonPropertyName("category_titles")] public List<string>? CategoryTitles { get; init; }

    [JsonPropertyName("term_titles")] public List<string>? TermTitles { get; init; }

    [JsonPropertyName("style_id")] public object? StyleId { get; init; }

    [JsonPropertyName("style_title")] public object? StyleTitle { get; init; }

    [JsonPropertyName("alt_style_ids")] public List<object>? AltStyleIds { get; init; }

    [JsonPropertyName("style_ids")] public List<object>? StyleIds { get; init; }

    [JsonPropertyName("style_titles")] public List<object>? StyleTitles { get; init; }

    [JsonPropertyName("classification_title")]
    public string? ClassificationTitle { get; init; }

    [JsonPropertyName("alt_classification_ids")]
    public List<string>? AltClassificationIds { get; init; }

    [JsonPropertyName("classification_ids")]
    public List<string>? ClassificationIds { get; init; }

    [JsonPropertyName("classification_titles")]
    public List<string>? ClassificationTitles { get; init; }

    [JsonPropertyName("subject_id")] public object? SubjectId { get; init; }

    [JsonPropertyName("alt_subject_ids")] public List<object>? AltSubjectIds { get; init; }

    [JsonPropertyName("subject_ids")] public List<object>? SubjectIds { get; init; }

    [JsonPropertyName("subject_titles")] public List<object>? SubjectTitles { get; init; }
    
    [JsonPropertyName("updated_at")] public DateTime? UpdatedAt { get; init; }
}
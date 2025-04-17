using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200011F RID: 287
	public class RenderCloudCubemap : MonoBehaviour
	{
		// Token: 0x06001870 RID: 6256 RVA: 0x000BC988 File Offset: 0x000BAB88
		// Note: this type is marked as 'beforefieldinit'.
		static RenderCloudCubemap()
		{
			Il2CppClassPointerStore<RenderCloudCubemap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "RenderCloudCubemap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderCloudCubemap>.NativeClassPtr);
			RenderCloudCubemap.NativeFieldInfoPtr_kDefaultFilenamePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderCloudCubemap>.NativeClassPtr, "kDefaultFilenamePrefix");
			RenderCloudCubemap.NativeFieldInfoPtr_filenamePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderCloudCubemap>.NativeClassPtr, "filenamePrefix");
			RenderCloudCubemap.NativeFieldInfoPtr_faceWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderCloudCubemap>.NativeClassPtr, "faceWidth");
			RenderCloudCubemap.NativeFieldInfoPtr_textureFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderCloudCubemap>.NativeClassPtr, "textureFormat");
			RenderCloudCubemap.NativeFieldInfoPtr_exportFaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderCloudCubemap>.NativeClassPtr, "exportFaces");
			RenderCloudCubemap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderCloudCubemap>.NativeClassPtr, 100665899);
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x000BCA30 File Offset: 0x000BAC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95293, XrefRangeEnd = 95298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderCloudCubemap() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderCloudCubemap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderCloudCubemap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x0000E0B4 File Offset: 0x0000C2B4
		public RenderCloudCubemap(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x000BCA6C File Offset: 0x000BAC6C
		// (set) Token: 0x06001874 RID: 6260 RVA: 0x0000E0BD File Offset: 0x0000C2BD
		public unsafe static string kDefaultFilenamePrefix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderCloudCubemap.NativeFieldInfoPtr_kDefaultFilenamePrefix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderCloudCubemap.NativeFieldInfoPtr_kDefaultFilenamePrefix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001875 RID: 6261 RVA: 0x000BCA8C File Offset: 0x000BAC8C
		// (set) Token: 0x06001876 RID: 6262 RVA: 0x0000E0CF File Offset: 0x0000C2CF
		public unsafe string filenamePrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderCloudCubemap.NativeFieldInfoPtr_filenamePrefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderCloudCubemap.NativeFieldInfoPtr_filenamePrefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001877 RID: 6263 RVA: 0x000BCAB4 File Offset: 0x000BACB4
		// (set) Token: 0x06001878 RID: 6264 RVA: 0x0000E0EE File Offset: 0x0000C2EE
		public unsafe int faceWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderCloudCubemap.NativeFieldInfoPtr_faceWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderCloudCubemap.NativeFieldInfoPtr_faceWidth)) = value;
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06001879 RID: 6265 RVA: 0x000BCADC File Offset: 0x000BACDC
		// (set) Token: 0x0600187A RID: 6266 RVA: 0x0000E109 File Offset: 0x0000C309
		public unsafe RenderCloudCubemap.CubemapTextureFormat textureFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderCloudCubemap.NativeFieldInfoPtr_textureFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderCloudCubemap.NativeFieldInfoPtr_textureFormat)) = value;
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x0600187B RID: 6267 RVA: 0x000BCB04 File Offset: 0x000BAD04
		// (set) Token: 0x0600187C RID: 6268 RVA: 0x0000E124 File Offset: 0x0000C324
		public unsafe bool exportFaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderCloudCubemap.NativeFieldInfoPtr_exportFaces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderCloudCubemap.NativeFieldInfoPtr_exportFaces)) = value;
			}
		}

		// Token: 0x0400100D RID: 4109
		private static readonly IntPtr NativeFieldInfoPtr_kDefaultFilenamePrefix;

		// Token: 0x0400100E RID: 4110
		private static readonly IntPtr NativeFieldInfoPtr_filenamePrefix;

		// Token: 0x0400100F RID: 4111
		private static readonly IntPtr NativeFieldInfoPtr_faceWidth;

		// Token: 0x04001010 RID: 4112
		private static readonly IntPtr NativeFieldInfoPtr_textureFormat;

		// Token: 0x04001011 RID: 4113
		private static readonly IntPtr NativeFieldInfoPtr_exportFaces;

		// Token: 0x04001012 RID: 4114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000855 RID: 2133
		[OriginalName("Assembly-CSharp.dll", "", "CubemapTextureFormat")]
		public enum CubemapTextureFormat
		{
			// Token: 0x04008251 RID: 33361
			RGBColor,
			// Token: 0x04008252 RID: 33362
			RGBAColor,
			// Token: 0x04008253 RID: 33363
			RGBALit
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000105 RID: 261
	[Serializable]
	public class TextureKeyframe : BaseKeyframe
	{
		// Token: 0x06001368 RID: 4968 RVA: 0x000AE87C File Offset: 0x000ACA7C
		// Note: this type is marked as 'beforefieldinit'.
		static TextureKeyframe()
		{
			Il2CppClassPointerStore<TextureKeyframe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "TextureKeyframe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureKeyframe>.NativeClassPtr);
			TextureKeyframe.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureKeyframe>.NativeClassPtr, "texture");
			TextureKeyframe.NativeMethodInfoPtr__ctor_Public_Void_Texture_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureKeyframe>.NativeClassPtr, 100665533);
			TextureKeyframe.NativeMethodInfoPtr__ctor_Public_Void_TextureKeyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureKeyframe>.NativeClassPtr, 100665534);
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x000AE8E8 File Offset: 0x000ACAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90315, XrefRangeEnd = 90320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureKeyframe(Texture texture, float time) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureKeyframe>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureKeyframe.NativeMethodInfoPtr__ctor_Public_Void_Texture_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x000AE944 File Offset: 0x000ACB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90320, XrefRangeEnd = 90325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureKeyframe(TextureKeyframe keyframe) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureKeyframe>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyframe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureKeyframe.NativeMethodInfoPtr__ctor_Public_Void_TextureKeyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x0000B7DB File Offset: 0x000099DB
		public TextureKeyframe(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x000AE990 File Offset: 0x000ACB90
		// (set) Token: 0x0600136D RID: 4973 RVA: 0x0000B7E4 File Offset: 0x000099E4
		public unsafe Texture texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureKeyframe.NativeFieldInfoPtr_texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureKeyframe.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeFieldInfoPtr_texture;

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Texture_Single_0;

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextureKeyframe_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000072 RID: 114
	public class PostProcessingComponentRenderTexture<T> : PostProcessingComponent<T> where T : PostProcessingModel
	{
		// Token: 0x0600081B RID: 2075 RVA: 0x00089520 File Offset: 0x00087720
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessingComponentRenderTexture()
		{
			Il2CppClassPointerStore<PostProcessingComponentRenderTexture<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "PostProcessingComponentRenderTexture`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessingComponentRenderTexture<T>>.NativeClassPtr);
			PostProcessingComponentRenderTexture<T>.NativeMethodInfoPtr_Prepare_Public_Virtual_New_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingComponentRenderTexture<T>>.NativeClassPtr, 100664168);
			PostProcessingComponentRenderTexture<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingComponentRenderTexture<T>>.NativeClassPtr, 100664169);
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x000895B4 File Offset: 0x000877B4
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Prepare(Material material)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessingComponentRenderTexture<T>.NativeMethodInfoPtr_Prepare_Public_Virtual_New_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00089604 File Offset: 0x00087804
		[CallerCount(263)]
		[CachedScanResults(RefRangeStart = 78510, RefRangeEnd = 78773, XrefRangeStart = 78510, XrefRangeEnd = 78773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessingComponentRenderTexture() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessingComponentRenderTexture<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingComponentRenderTexture<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00006638 File Offset: 0x00004838
		public PostProcessingComponentRenderTexture(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeMethodInfoPtr_Prepare_Public_Virtual_New_Void_Material_0;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

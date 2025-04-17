using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000078 RID: 120
	public sealed class MaterialFactory : Object
	{
		// Token: 0x0600087C RID: 2172 RVA: 0x0008A730 File Offset: 0x00088930
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialFactory()
		{
			Il2CppClassPointerStore<MaterialFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "MaterialFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialFactory>.NativeClassPtr);
			MaterialFactory.NativeFieldInfoPtr_m_Materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFactory>.NativeClassPtr, "m_Materials");
			MaterialFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFactory>.NativeClassPtr, 100664197);
			MaterialFactory.NativeMethodInfoPtr_Get_Public_Material_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFactory>.NativeClassPtr, 100664198);
			MaterialFactory.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFactory>.NativeClassPtr, 100664199);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x0008A7B0 File Offset: 0x000889B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79057, XrefRangeEnd = 79065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialFactory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0008A7EC File Offset: 0x000889EC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 79089, RefRangeEnd = 79111, XrefRangeStart = 79065, XrefRangeEnd = 79089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material Get(string shaderName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(shaderName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialFactory.NativeMethodInfoPtr_Get_Public_Material_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0008A83C File Offset: 0x00088A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79111, XrefRangeEnd = 79131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialFactory.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x000069A4 File Offset: 0x00004BA4
		public MaterialFactory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x0008A870 File Offset: 0x00088A70
		// (set) Token: 0x06000882 RID: 2178 RVA: 0x000069AD File Offset: 0x00004BAD
		public unsafe Dictionary<string, Material> m_Materials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFactory.NativeFieldInfoPtr_m_Materials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFactory.NativeFieldInfoPtr_m_Materials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeFieldInfoPtr_m_Materials;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Material_String_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}

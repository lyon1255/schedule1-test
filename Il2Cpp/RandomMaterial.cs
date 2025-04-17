using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000033 RID: 51
	public class RandomMaterial : MonoBehaviour
	{
		// Token: 0x0600038E RID: 910 RVA: 0x0007B59C File Offset: 0x0007979C
		// Note: this type is marked as 'beforefieldinit'.
		static RandomMaterial()
		{
			Il2CppClassPointerStore<RandomMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RandomMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomMaterial>.NativeClassPtr);
			RandomMaterial.NativeFieldInfoPtr_targetRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomMaterial>.NativeClassPtr, "targetRenderer");
			RandomMaterial.NativeFieldInfoPtr_materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomMaterial>.NativeClassPtr, "materials");
			RandomMaterial.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomMaterial>.NativeClassPtr, 100663637);
			RandomMaterial.NativeMethodInfoPtr_ChangeMaterial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomMaterial>.NativeClassPtr, 100663638);
			RandomMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomMaterial>.NativeClassPtr, 100663639);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0007B630 File Offset: 0x00079830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73687, XrefRangeEnd = 73691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomMaterial.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0007B664 File Offset: 0x00079864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomMaterial.NativeMethodInfoPtr_ChangeMaterial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0007B698 File Offset: 0x00079898
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RandomMaterial() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomMaterial>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000404E File Offset: 0x0000224E
		public RandomMaterial(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000393 RID: 915 RVA: 0x0007B6D4 File Offset: 0x000798D4
		// (set) Token: 0x06000394 RID: 916 RVA: 0x00004057 File Offset: 0x00002257
		public unsafe Renderer targetRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMaterial.NativeFieldInfoPtr_targetRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMaterial.NativeFieldInfoPtr_targetRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000395 RID: 917 RVA: 0x0007B704 File Offset: 0x00079904
		// (set) Token: 0x06000396 RID: 918 RVA: 0x00004076 File Offset: 0x00002276
		public unsafe Il2CppReferenceArray<Material> materials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMaterial.NativeFieldInfoPtr_materials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMaterial.NativeFieldInfoPtr_materials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeFieldInfoPtr_targetRenderer;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeFieldInfoPtr_materials;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_ChangeMaterial_Public_Void_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

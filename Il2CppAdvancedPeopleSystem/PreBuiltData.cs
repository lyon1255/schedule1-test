using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000154 RID: 340
	[Serializable]
	public class PreBuiltData : Il2CppSystem.Object
	{
		// Token: 0x06001BC4 RID: 7108 RVA: 0x000C7120 File Offset: 0x000C5320
		// Note: this type is marked as 'beforefieldinit'.
		static PreBuiltData()
		{
			Il2CppClassPointerStore<PreBuiltData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "PreBuiltData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreBuiltData>.NativeClassPtr);
			PreBuiltData.NativeFieldInfoPtr_GroupName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreBuiltData>.NativeClassPtr, "GroupName");
			PreBuiltData.NativeFieldInfoPtr_meshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreBuiltData>.NativeClassPtr, "meshes");
			PreBuiltData.NativeFieldInfoPtr_materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreBuiltData>.NativeClassPtr, "materials");
			PreBuiltData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreBuiltData>.NativeClassPtr, 100666235);
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x000C71A0 File Offset: 0x000C53A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100485, XrefRangeEnd = 100500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreBuiltData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreBuiltData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreBuiltData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x0000FBA1 File Offset: 0x0000DDA1
		public PreBuiltData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06001BC7 RID: 7111 RVA: 0x000C71DC File Offset: 0x000C53DC
		// (set) Token: 0x06001BC8 RID: 7112 RVA: 0x0000FBAA File Offset: 0x0000DDAA
		public unsafe string GroupName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreBuiltData.NativeFieldInfoPtr_GroupName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreBuiltData.NativeFieldInfoPtr_GroupName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06001BC9 RID: 7113 RVA: 0x000C7204 File Offset: 0x000C5404
		// (set) Token: 0x06001BCA RID: 7114 RVA: 0x0000FBC9 File Offset: 0x0000DDC9
		public unsafe List<Mesh> meshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreBuiltData.NativeFieldInfoPtr_meshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Mesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreBuiltData.NativeFieldInfoPtr_meshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06001BCB RID: 7115 RVA: 0x000C7234 File Offset: 0x000C5434
		// (set) Token: 0x06001BCC RID: 7116 RVA: 0x0000FBE8 File Offset: 0x0000DDE8
		public unsafe List<Material> materials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreBuiltData.NativeFieldInfoPtr_materials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreBuiltData.NativeFieldInfoPtr_materials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001242 RID: 4674
		private static readonly IntPtr NativeFieldInfoPtr_GroupName;

		// Token: 0x04001243 RID: 4675
		private static readonly IntPtr NativeFieldInfoPtr_meshes;

		// Token: 0x04001244 RID: 4676
		private static readonly IntPtr NativeFieldInfoPtr_materials;

		// Token: 0x04001245 RID: 4677
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

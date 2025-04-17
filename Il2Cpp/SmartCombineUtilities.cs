using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000030 RID: 48
	public static class SmartCombineUtilities : Il2CppSystem.Object
	{
		// Token: 0x06000357 RID: 855 RVA: 0x00003D8E File Offset: 0x00001F8E
		// Note: this type is marked as 'beforefieldinit'.
		static SmartCombineUtilities()
		{
			Il2CppClassPointerStore<SmartCombineUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SmartCombineUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmartCombineUtilities>.NativeClassPtr);
			SmartCombineUtilities.NativeMethodInfoPtr_CombineMeshesSmart_Public_Static_Void_Mesh_Il2CppReferenceArray_1_SmartMeshData_byref_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartCombineUtilities>.NativeClassPtr, 100663622);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0007AD10 File Offset: 0x00078F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73342, XrefRangeEnd = 73439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CombineMeshesSmart(this Mesh mesh, Il2CppReferenceArray<SmartMeshData> meshData, out Il2CppReferenceArray<Material> materials)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(meshData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SmartCombineUtilities.NativeMethodInfoPtr_CombineMeshesSmart_Public_Static_Void_Mesh_Il2CppReferenceArray_1_SmartMeshData_byref_Il2CppReferenceArray_1_Material_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			materials = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<Material>(intPtr4));
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00003DC7 File Offset: 0x00001FC7
		public SmartCombineUtilities(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_CombineMeshesSmart_Public_Static_Void_Mesh_Il2CppReferenceArray_1_SmartMeshData_byref_Il2CppReferenceArray_1_Material_0;

		// Token: 0x020007B2 RID: 1970
		public class SmartSubmeshData : Il2CppSystem.Object
		{
			// Token: 0x0600B9AF RID: 47535 RVA: 0x002E1430 File Offset: 0x002DF630
			// Note: this type is marked as 'beforefieldinit'.
			static SmartSubmeshData()
			{
				Il2CppClassPointerStore<SmartCombineUtilities.SmartSubmeshData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SmartCombineUtilities>.NativeClassPtr, "SmartSubmeshData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmartCombineUtilities.SmartSubmeshData>.NativeClassPtr);
				SmartCombineUtilities.SmartSubmeshData.NativeFieldInfoPtr__mesh_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmartCombineUtilities.SmartSubmeshData>.NativeClassPtr, "<mesh>k__BackingField");
				SmartCombineUtilities.SmartSubmeshData.NativeFieldInfoPtr__combineInstances_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmartCombineUtilities.SmartSubmeshData>.NativeClassPtr, "<combineInstances>k__BackingField");
				SmartCombineUtilities.SmartSubmeshData.NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartCombineUtilities.SmartSubmeshData>.NativeClassPtr, 100663623);
				SmartCombineUtilities.SmartSubmeshData.NativeMethodInfoPtr_set_mesh_Private_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartCombineUtilities.SmartSubmeshData>.NativeClassPtr, 100663624);
				SmartCombineUtilities.SmartSubmeshData.NativeMethodInfoPtr_get_combineInstances_Public_get_IList_1_CombineInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartCombineUtilities.SmartSubmeshData>.NativeClassPtr, 100663625);
				SmartCombineUtilities.SmartSubmeshData.NativeMethodInfoPtr_set_combineInstances_Private_set_Void_IList_1_CombineInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartCombineUtilities.SmartSubmeshData>.NativeClassPtr, 100663626);
				SmartCombineUtilities.SmartSubmeshData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartCombineUtilities.SmartSubmeshData>.NativeClassPtr, 100663627);
				SmartCombineUtilities.SmartSubmeshData.NativeMethodInfoPtr_CombineSubmeshes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartCombineUtilities.SmartSubmeshData>.NativeClassPtr, 100663628);
			}

			// Token: 0x1700394C RID: 14668
			// (get) Token: 0x0600B9B0 RID: 47536 RVA: 0x002E14FC File Offset: 0x002DF6FC
			// (set) Token: 0x0600B9B1 RID: 47537 RVA: 0x002E153C File Offset: 0x002DF73C
			public unsafe Mesh mesh
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 17383, RefRangeEnd = 17393, XrefRangeStart = 17383, XrefRangeEnd = 17393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartCombineUtilities.SmartSubmeshData.NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 29994, RefRangeEnd = 29996, XrefRangeStart = 29994, XrefRangeEnd = 29996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartCombineUtilities.SmartSubmeshData.NativeMethodInfoPtr_set_mesh_Private_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700394D RID: 14669
			// (get) Token: 0x0600B9B2 RID: 47538 RVA: 0x002E1580 File Offset: 0x002DF780
			// (set) Token: 0x0600B9B3 RID: 47539 RVA: 0x002E15C0 File Offset: 0x002DF7C0
			public unsafe IList<CombineInstance> combineInstances
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartCombineUtilities.SmartSubmeshData.NativeMethodInfoPtr_get_combineInstances_Public_get_IList_1_CombineInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CombineInstance>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartCombineUtilities.SmartSubmeshData.NativeMethodInfoPtr_set_combineInstances_Private_set_Void_IList_1_CombineInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600B9B4 RID: 47540 RVA: 0x002E1604 File Offset: 0x002DF804
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73326, RefRangeEnd = 73327, XrefRangeStart = 73318, XrefRangeEnd = 73326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SmartSubmeshData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmartCombineUtilities.SmartSubmeshData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartCombineUtilities.SmartSubmeshData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9B5 RID: 47541 RVA: 0x002E1640 File Offset: 0x002DF840
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73327, XrefRangeEnd = 73342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CombineSubmeshes()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartCombineUtilities.SmartSubmeshData.NativeMethodInfoPtr_CombineSubmeshes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9B6 RID: 47542 RVA: 0x0005AC8B File Offset: 0x00058E8B
			public SmartSubmeshData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700394A RID: 14666
			// (get) Token: 0x0600B9B7 RID: 47543 RVA: 0x002E1674 File Offset: 0x002DF874
			// (set) Token: 0x0600B9B8 RID: 47544 RVA: 0x0005AC94 File Offset: 0x00058E94
			public unsafe Mesh _mesh_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartCombineUtilities.SmartSubmeshData.NativeFieldInfoPtr__mesh_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartCombineUtilities.SmartSubmeshData.NativeFieldInfoPtr__mesh_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700394B RID: 14667
			// (get) Token: 0x0600B9B9 RID: 47545 RVA: 0x002E16A4 File Offset: 0x002DF8A4
			// (set) Token: 0x0600B9BA RID: 47546 RVA: 0x0005ACB3 File Offset: 0x00058EB3
			public unsafe IList<CombineInstance> _combineInstances_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartCombineUtilities.SmartSubmeshData.NativeFieldInfoPtr__combineInstances_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<CombineInstance>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartCombineUtilities.SmartSubmeshData.NativeFieldInfoPtr__combineInstances_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D3E RID: 32062
			private static readonly IntPtr NativeFieldInfoPtr__mesh_k__BackingField;

			// Token: 0x04007D3F RID: 32063
			private static readonly IntPtr NativeFieldInfoPtr__combineInstances_k__BackingField;

			// Token: 0x04007D40 RID: 32064
			private static readonly IntPtr NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0;

			// Token: 0x04007D41 RID: 32065
			private static readonly IntPtr NativeMethodInfoPtr_set_mesh_Private_set_Void_Mesh_0;

			// Token: 0x04007D42 RID: 32066
			private static readonly IntPtr NativeMethodInfoPtr_get_combineInstances_Public_get_IList_1_CombineInstance_0;

			// Token: 0x04007D43 RID: 32067
			private static readonly IntPtr NativeMethodInfoPtr_set_combineInstances_Private_set_Void_IList_1_CombineInstance_0;

			// Token: 0x04007D44 RID: 32068
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D45 RID: 32069
			private static readonly IntPtr NativeMethodInfoPtr_CombineSubmeshes_Public_Void_0;
		}
	}
}

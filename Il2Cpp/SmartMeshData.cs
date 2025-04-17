﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200002F RID: 47
	public class SmartMeshData : Il2CppSystem.Object
	{
		// Token: 0x06000345 RID: 837 RVA: 0x0007A7D8 File Offset: 0x000789D8
		// Note: this type is marked as 'beforefieldinit'.
		static SmartMeshData()
		{
			Il2CppClassPointerStore<SmartMeshData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SmartMeshData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmartMeshData>.NativeClassPtr);
			SmartMeshData.NativeFieldInfoPtr__mesh_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmartMeshData>.NativeClassPtr, "<mesh>k__BackingField");
			SmartMeshData.NativeFieldInfoPtr__transform_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmartMeshData>.NativeClassPtr, "<transform>k__BackingField");
			SmartMeshData.NativeFieldInfoPtr__materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmartMeshData>.NativeClassPtr, "_materials");
			SmartMeshData.NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartMeshData>.NativeClassPtr, 100663612);
			SmartMeshData.NativeMethodInfoPtr_set_mesh_Private_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartMeshData>.NativeClassPtr, 100663613);
			SmartMeshData.NativeMethodInfoPtr_get_transform_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartMeshData>.NativeClassPtr, 100663614);
			SmartMeshData.NativeMethodInfoPtr_set_transform_Private_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartMeshData>.NativeClassPtr, 100663615);
			SmartMeshData.NativeMethodInfoPtr_get_materials_Public_get_IList_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartMeshData>.NativeClassPtr, 100663616);
			SmartMeshData.NativeMethodInfoPtr__ctor_Public_Void_Mesh_Il2CppReferenceArray_1_Material_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartMeshData>.NativeClassPtr, 100663617);
			SmartMeshData.NativeMethodInfoPtr__ctor_Public_Void_Mesh_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartMeshData>.NativeClassPtr, 100663618);
			SmartMeshData.NativeMethodInfoPtr__ctor_Public_Void_Mesh_Il2CppReferenceArray_1_Material_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartMeshData>.NativeClassPtr, 100663619);
			SmartMeshData.NativeMethodInfoPtr__ctor_Public_Void_Mesh_Il2CppReferenceArray_1_Material_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartMeshData>.NativeClassPtr, 100663620);
			SmartMeshData.NativeMethodInfoPtr__ctor_Public_Void_Mesh_Il2CppReferenceArray_1_Material_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartMeshData>.NativeClassPtr, 100663621);
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000346 RID: 838 RVA: 0x0007A90C File Offset: 0x00078B0C
		// (set) Token: 0x06000347 RID: 839 RVA: 0x0007A94C File Offset: 0x00078B4C
		public unsafe Mesh mesh
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17383, RefRangeEnd = 17393, XrefRangeStart = 17383, XrefRangeEnd = 17393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartMeshData.NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartMeshData.NativeMethodInfoPtr_set_mesh_Private_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000348 RID: 840 RVA: 0x0007A990 File Offset: 0x00078B90
		// (set) Token: 0x06000349 RID: 841 RVA: 0x0007A9CC File Offset: 0x00078BCC
		public unsafe Matrix4x4 transform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartMeshData.NativeMethodInfoPtr_get_transform_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartMeshData.NativeMethodInfoPtr_set_transform_Private_set_Void_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0007AA0C File Offset: 0x00078C0C
		public unsafe IList<Material> materials
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73274, XrefRangeEnd = 73280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartMeshData.NativeMethodInfoPtr_get_materials_Public_get_IList_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Material>>(intPtr3) : null;
			}
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0007AA4C File Offset: 0x00078C4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 73299, RefRangeEnd = 73303, XrefRangeStart = 73280, XrefRangeEnd = 73299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmartMeshData(Mesh inMesh, Il2CppReferenceArray<Material> inMaterials, Matrix4x4 inTransform) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmartMeshData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inMesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inMaterials);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inTransform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartMeshData.NativeMethodInfoPtr__ctor_Public_Void_Mesh_Il2CppReferenceArray_1_Material_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0007AAB8 File Offset: 0x00078CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73303, XrefRangeEnd = 73306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmartMeshData(Mesh inputMesh, Il2CppReferenceArray<Material> inputMaterials) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmartMeshData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputMesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputMaterials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartMeshData.NativeMethodInfoPtr__ctor_Public_Void_Mesh_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0007AB18 File Offset: 0x00078D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73306, XrefRangeEnd = 73312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmartMeshData(Mesh inputMesh, Il2CppReferenceArray<Material> inputMaterials, Vector3 position) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmartMeshData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputMesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputMaterials);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartMeshData.NativeMethodInfoPtr__ctor_Public_Void_Mesh_Il2CppReferenceArray_1_Material_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0007AB84 File Offset: 0x00078D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73312, XrefRangeEnd = 73316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmartMeshData(Mesh inputMesh, Il2CppReferenceArray<Material> inputMaterials, Vector3 position, Quaternion rotation) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmartMeshData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputMesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputMaterials);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartMeshData.NativeMethodInfoPtr__ctor_Public_Void_Mesh_Il2CppReferenceArray_1_Material_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0007AC00 File Offset: 0x00078E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73316, XrefRangeEnd = 73318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmartMeshData(Mesh inputMesh, Il2CppReferenceArray<Material> inputMaterials, Vector3 position, Quaternion rotation, Vector3 scale) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmartMeshData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputMesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputMaterials);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartMeshData.NativeMethodInfoPtr__ctor_Public_Void_Mesh_Il2CppReferenceArray_1_Material_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00003D2C File Offset: 0x00001F2C
		public SmartMeshData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000351 RID: 849 RVA: 0x0007AC88 File Offset: 0x00078E88
		// (set) Token: 0x06000352 RID: 850 RVA: 0x00003D35 File Offset: 0x00001F35
		public unsafe Mesh _mesh_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartMeshData.NativeFieldInfoPtr__mesh_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartMeshData.NativeFieldInfoPtr__mesh_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000353 RID: 851 RVA: 0x0007ACB8 File Offset: 0x00078EB8
		// (set) Token: 0x06000354 RID: 852 RVA: 0x00003D54 File Offset: 0x00001F54
		public unsafe Matrix4x4 _transform_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartMeshData.NativeFieldInfoPtr__transform_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartMeshData.NativeFieldInfoPtr__transform_k__BackingField)) = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000355 RID: 853 RVA: 0x0007ACE0 File Offset: 0x00078EE0
		// (set) Token: 0x06000356 RID: 854 RVA: 0x00003D6F File Offset: 0x00001F6F
		public unsafe Il2CppReferenceArray<Material> _materials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartMeshData.NativeFieldInfoPtr__materials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartMeshData.NativeFieldInfoPtr__materials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeFieldInfoPtr__mesh_k__BackingField;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeFieldInfoPtr__transform_k__BackingField;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeFieldInfoPtr__materials;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_set_mesh_Private_set_Void_Mesh_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_get_transform_Public_get_Matrix4x4_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_set_transform_Private_set_Void_Matrix4x4_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_get_materials_Public_get_IList_1_Material_0;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Mesh_Il2CppReferenceArray_1_Material_Matrix4x4_0;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Mesh_Il2CppReferenceArray_1_Material_0;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Mesh_Il2CppReferenceArray_1_Material_Vector3_0;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Mesh_Il2CppReferenceArray_1_Material_Vector3_Quaternion_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Mesh_Il2CppReferenceArray_1_Material_Vector3_Quaternion_Vector3_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200002A RID: 42
	public class MeshCombiner : MonoBehaviour
	{
		// Token: 0x060002F3 RID: 755 RVA: 0x00079758 File Offset: 0x00077958
		// Note: this type is marked as 'beforefieldinit'.
		static MeshCombiner()
		{
			Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MeshCombiner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr);
			MeshCombiner.NativeFieldInfoPtr_Mesh16BitBufferVertexLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "Mesh16BitBufferVertexLimit");
			MeshCombiner.NativeFieldInfoPtr_createMultiMaterialMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "createMultiMaterialMesh");
			MeshCombiner.NativeFieldInfoPtr_combineInactiveChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "combineInactiveChildren");
			MeshCombiner.NativeFieldInfoPtr_deactivateCombinedChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "deactivateCombinedChildren");
			MeshCombiner.NativeFieldInfoPtr_deactivateCombinedChildrenMeshRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "deactivateCombinedChildrenMeshRenderers");
			MeshCombiner.NativeFieldInfoPtr_generateUVMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "generateUVMap");
			MeshCombiner.NativeFieldInfoPtr_destroyCombinedChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "destroyCombinedChildren");
			MeshCombiner.NativeFieldInfoPtr_folderPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "folderPath");
			MeshCombiner.NativeFieldInfoPtr_meshFiltersToSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "meshFiltersToSkip");
			MeshCombiner.NativeMethodInfoPtr_get_CreateMultiMaterialMesh_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663565);
			MeshCombiner.NativeMethodInfoPtr_set_CreateMultiMaterialMesh_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663566);
			MeshCombiner.NativeMethodInfoPtr_get_CombineInactiveChildren_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663567);
			MeshCombiner.NativeMethodInfoPtr_set_CombineInactiveChildren_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663568);
			MeshCombiner.NativeMethodInfoPtr_get_DeactivateCombinedChildren_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663569);
			MeshCombiner.NativeMethodInfoPtr_set_DeactivateCombinedChildren_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663570);
			MeshCombiner.NativeMethodInfoPtr_get_DeactivateCombinedChildrenMeshRenderers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663571);
			MeshCombiner.NativeMethodInfoPtr_set_DeactivateCombinedChildrenMeshRenderers_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663572);
			MeshCombiner.NativeMethodInfoPtr_get_GenerateUVMap_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663573);
			MeshCombiner.NativeMethodInfoPtr_set_GenerateUVMap_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663574);
			MeshCombiner.NativeMethodInfoPtr_get_DestroyCombinedChildren_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663575);
			MeshCombiner.NativeMethodInfoPtr_set_DestroyCombinedChildren_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663576);
			MeshCombiner.NativeMethodInfoPtr_get_FolderPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663577);
			MeshCombiner.NativeMethodInfoPtr_set_FolderPath_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663578);
			MeshCombiner.NativeMethodInfoPtr_CheckDeactivateCombinedChildren_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663579);
			MeshCombiner.NativeMethodInfoPtr_CheckDestroyCombinedChildren_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663580);
			MeshCombiner.NativeMethodInfoPtr_CombineMeshes_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663581);
			MeshCombiner.NativeMethodInfoPtr_GetMeshFiltersToCombine_Private_Il2CppReferenceArray_1_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663582);
			MeshCombiner.NativeMethodInfoPtr_CombineMeshesWithSingleMaterial_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663583);
			MeshCombiner.NativeMethodInfoPtr_CombineMeshesWithMutliMaterial_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663584);
			MeshCombiner.NativeMethodInfoPtr_DeactivateCombinedGameObjects_Private_Void_Il2CppReferenceArray_1_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663585);
			MeshCombiner.NativeMethodInfoPtr_GenerateUV_Private_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663586);
			MeshCombiner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663587);
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00079A08 File Offset: 0x00077C08
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x00079A44 File Offset: 0x00077C44
		public unsafe bool CreateMultiMaterialMesh
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_get_CreateMultiMaterialMesh_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_set_CreateMultiMaterialMesh_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00079A84 File Offset: 0x00077C84
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x00079AC0 File Offset: 0x00077CC0
		public unsafe bool CombineInactiveChildren
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_get_CombineInactiveChildren_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_set_CombineInactiveChildren_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00079B00 File Offset: 0x00077D00
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x00079B3C File Offset: 0x00077D3C
		public unsafe bool DeactivateCombinedChildren
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_get_DeactivateCombinedChildren_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_set_DeactivateCombinedChildren_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00079B7C File Offset: 0x00077D7C
		// (set) Token: 0x060002FB RID: 763 RVA: 0x00079BB8 File Offset: 0x00077DB8
		public unsafe bool DeactivateCombinedChildrenMeshRenderers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_get_DeactivateCombinedChildrenMeshRenderers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_set_DeactivateCombinedChildrenMeshRenderers_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002FC RID: 764 RVA: 0x00079BF8 File Offset: 0x00077DF8
		// (set) Token: 0x060002FD RID: 765 RVA: 0x00079C34 File Offset: 0x00077E34
		public unsafe bool GenerateUVMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_get_GenerateUVMap_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_set_GenerateUVMap_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002FE RID: 766 RVA: 0x00079C74 File Offset: 0x00077E74
		// (set) Token: 0x060002FF RID: 767 RVA: 0x00079CB0 File Offset: 0x00077EB0
		public unsafe bool DestroyCombinedChildren
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_get_DestroyCombinedChildren_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_set_DestroyCombinedChildren_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000300 RID: 768 RVA: 0x00079CF0 File Offset: 0x00077EF0
		// (set) Token: 0x06000301 RID: 769 RVA: 0x00079D28 File Offset: 0x00077F28
		public unsafe string FolderPath
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_get_FolderPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_set_FolderPath_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00079D6C File Offset: 0x00077F6C
		[CallerCount(0)]
		public unsafe void CheckDeactivateCombinedChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_CheckDeactivateCombinedChildren_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00079DA0 File Offset: 0x00077FA0
		[CallerCount(0)]
		public unsafe void CheckDestroyCombinedChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_CheckDestroyCombinedChildren_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00079DD4 File Offset: 0x00077FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72816, XrefRangeEnd = 72857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CombineMeshes(bool showCreatedMeshInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref showCreatedMeshInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_CombineMeshes_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00079E14 File Offset: 0x00078014
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72914, RefRangeEnd = 72916, XrefRangeStart = 72857, XrefRangeEnd = 72914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<MeshFilter> GetMeshFiltersToCombine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_GetMeshFiltersToCombine_Private_Il2CppReferenceArray_1_MeshFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshFilter>>(intPtr3) : null;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00079E54 File Offset: 0x00078054
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72980, RefRangeEnd = 72981, XrefRangeStart = 72916, XrefRangeEnd = 72980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CombineMeshesWithSingleMaterial(bool showCreatedMeshInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref showCreatedMeshInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_CombineMeshesWithSingleMaterial_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00079E94 File Offset: 0x00078094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73113, RefRangeEnd = 73114, XrefRangeStart = 72981, XrefRangeEnd = 73113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CombineMeshesWithMutliMaterial(bool showCreatedMeshInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref showCreatedMeshInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_CombineMeshesWithMutliMaterial_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00079ED4 File Offset: 0x000780D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73131, RefRangeEnd = 73133, XrefRangeStart = 73114, XrefRangeEnd = 73131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeactivateCombinedGameObjects(Il2CppReferenceArray<MeshFilter> meshFilters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshFilters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_DeactivateCombinedGameObjects_Private_Void_Il2CppReferenceArray_1_MeshFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00079F18 File Offset: 0x00078118
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateUV(Mesh combinedMesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(combinedMesh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_GenerateUV_Private_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00079F5C File Offset: 0x0007815C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73133, XrefRangeEnd = 73142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshCombiner() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00003AE7 File Offset: 0x00001CE7
		public MeshCombiner(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600030C RID: 780 RVA: 0x00079F98 File Offset: 0x00078198
		// (set) Token: 0x0600030D RID: 781 RVA: 0x00003AF0 File Offset: 0x00001CF0
		public unsafe static int Mesh16BitBufferVertexLimit
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(MeshCombiner.NativeFieldInfoPtr_Mesh16BitBufferVertexLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MeshCombiner.NativeFieldInfoPtr_Mesh16BitBufferVertexLimit, (void*)(&value));
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600030E RID: 782 RVA: 0x00079FB4 File Offset: 0x000781B4
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00003AFE File Offset: 0x00001CFE
		public unsafe bool createMultiMaterialMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_createMultiMaterialMesh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_createMultiMaterialMesh)) = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000310 RID: 784 RVA: 0x00079FDC File Offset: 0x000781DC
		// (set) Token: 0x06000311 RID: 785 RVA: 0x00003B19 File Offset: 0x00001D19
		public unsafe bool combineInactiveChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_combineInactiveChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_combineInactiveChildren)) = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0007A004 File Offset: 0x00078204
		// (set) Token: 0x06000313 RID: 787 RVA: 0x00003B34 File Offset: 0x00001D34
		public unsafe bool deactivateCombinedChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_deactivateCombinedChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_deactivateCombinedChildren)) = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0007A02C File Offset: 0x0007822C
		// (set) Token: 0x06000315 RID: 789 RVA: 0x00003B4F File Offset: 0x00001D4F
		public unsafe bool deactivateCombinedChildrenMeshRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_deactivateCombinedChildrenMeshRenderers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_deactivateCombinedChildrenMeshRenderers)) = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000316 RID: 790 RVA: 0x0007A054 File Offset: 0x00078254
		// (set) Token: 0x06000317 RID: 791 RVA: 0x00003B6A File Offset: 0x00001D6A
		public unsafe bool generateUVMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_generateUVMap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_generateUVMap)) = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000318 RID: 792 RVA: 0x0007A07C File Offset: 0x0007827C
		// (set) Token: 0x06000319 RID: 793 RVA: 0x00003B85 File Offset: 0x00001D85
		public unsafe bool destroyCombinedChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_destroyCombinedChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_destroyCombinedChildren)) = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0007A0A4 File Offset: 0x000782A4
		// (set) Token: 0x0600031B RID: 795 RVA: 0x00003BA0 File Offset: 0x00001DA0
		public unsafe string folderPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_folderPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_folderPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600031C RID: 796 RVA: 0x0007A0CC File Offset: 0x000782CC
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00003BBF File Offset: 0x00001DBF
		public unsafe Il2CppReferenceArray<MeshFilter> meshFiltersToSkip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_meshFiltersToSkip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_meshFiltersToSkip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeFieldInfoPtr_Mesh16BitBufferVertexLimit;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeFieldInfoPtr_createMultiMaterialMesh;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeFieldInfoPtr_combineInactiveChildren;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeFieldInfoPtr_deactivateCombinedChildren;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeFieldInfoPtr_deactivateCombinedChildrenMeshRenderers;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeFieldInfoPtr_generateUVMap;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeFieldInfoPtr_destroyCombinedChildren;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeFieldInfoPtr_folderPath;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeFieldInfoPtr_meshFiltersToSkip;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_get_CreateMultiMaterialMesh_Public_get_Boolean_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_set_CreateMultiMaterialMesh_Public_set_Void_Boolean_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_get_CombineInactiveChildren_Public_get_Boolean_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_set_CombineInactiveChildren_Public_set_Void_Boolean_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_get_DeactivateCombinedChildren_Public_get_Boolean_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_set_DeactivateCombinedChildren_Public_set_Void_Boolean_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_get_DeactivateCombinedChildrenMeshRenderers_Public_get_Boolean_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_set_DeactivateCombinedChildrenMeshRenderers_Public_set_Void_Boolean_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_get_GenerateUVMap_Public_get_Boolean_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_set_GenerateUVMap_Public_set_Void_Boolean_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_get_DestroyCombinedChildren_Public_get_Boolean_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_set_DestroyCombinedChildren_Public_set_Void_Boolean_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_get_FolderPath_Public_get_String_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_set_FolderPath_Public_set_Void_String_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_CheckDeactivateCombinedChildren_Private_Void_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_CheckDestroyCombinedChildren_Private_Void_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_CombineMeshes_Public_Void_Boolean_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshFiltersToCombine_Private_Il2CppReferenceArray_1_MeshFilter_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_CombineMeshesWithSingleMaterial_Private_Void_Boolean_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_CombineMeshesWithMutliMaterial_Private_Void_Boolean_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateCombinedGameObjects_Private_Void_Il2CppReferenceArray_1_MeshFilter_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_GenerateUV_Private_Void_Mesh_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007AE RID: 1966
		[ObfuscatedName("MeshCombiner+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600B97D RID: 47485 RVA: 0x002E0BD4 File Offset: 0x002DEDD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MeshCombiner.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshCombiner.__c>.NativeClassPtr);
				MeshCombiner.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner.__c>.NativeClassPtr, "<>9");
				MeshCombiner.__c.NativeFieldInfoPtr___9__33_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner.__c>.NativeClassPtr, "<>9__33_1");
				MeshCombiner.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner.__c>.NativeClassPtr, 100663589);
				MeshCombiner.__c.NativeMethodInfoPtr__GetMeshFiltersToCombine_b__33_1_Internal_Boolean_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner.__c>.NativeClassPtr, 100663590);
			}

			// Token: 0x0600B97E RID: 47486 RVA: 0x002E0C50 File Offset: 0x002DEE50
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshCombiner.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B97F RID: 47487 RVA: 0x002E0C8C File Offset: 0x002DEE8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72800, XrefRangeEnd = 72804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetMeshFiltersToCombine_b__33_1(MeshFilter meshFilter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshFilter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.__c.NativeMethodInfoPtr__GetMeshFiltersToCombine_b__33_1_Internal_Boolean_MeshFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B980 RID: 47488 RVA: 0x0005AAD0 File Offset: 0x00058CD0
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003939 RID: 14649
			// (get) Token: 0x0600B981 RID: 47489 RVA: 0x002E0CDC File Offset: 0x002DEEDC
			// (set) Token: 0x0600B982 RID: 47490 RVA: 0x0005AAD9 File Offset: 0x00058CD9
			public unsafe static MeshCombiner.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MeshCombiner.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshCombiner.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MeshCombiner.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700393A RID: 14650
			// (get) Token: 0x0600B983 RID: 47491 RVA: 0x002E0D04 File Offset: 0x002DEF04
			// (set) Token: 0x0600B984 RID: 47492 RVA: 0x0005AAEB File Offset: 0x00058CEB
			public unsafe static Func<MeshFilter, bool> __9__33_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MeshCombiner.__c.NativeFieldInfoPtr___9__33_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MeshFilter, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MeshCombiner.__c.NativeFieldInfoPtr___9__33_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D23 RID: 32035
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007D24 RID: 32036
			private static readonly IntPtr NativeFieldInfoPtr___9__33_1;

			// Token: 0x04007D25 RID: 32037
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D26 RID: 32038
			private static readonly IntPtr NativeMethodInfoPtr__GetMeshFiltersToCombine_b__33_1_Internal_Boolean_MeshFilter_0;
		}

		// Token: 0x020007AF RID: 1967
		[ObfuscatedName("MeshCombiner+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B985 RID: 47493 RVA: 0x002E0D2C File Offset: 0x002DEF2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_0>.NativeClassPtr);
				MeshCombiner.__c__DisplayClass33_0.NativeFieldInfoPtr_meshFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_0>.NativeClassPtr, "meshFilters");
				MeshCombiner.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_0>.NativeClassPtr, "<>4__this");
				MeshCombiner.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_0>.NativeClassPtr, 100663591);
				MeshCombiner.__c__DisplayClass33_0.NativeMethodInfoPtr__GetMeshFiltersToCombine_b__0_Internal_Boolean_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_0>.NativeClassPtr, 100663592);
			}

			// Token: 0x0600B986 RID: 47494 RVA: 0x002E0DA8 File Offset: 0x002DEFA8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B987 RID: 47495 RVA: 0x002E0DE4 File Offset: 0x002DEFE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72804, XrefRangeEnd = 72810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetMeshFiltersToCombine_b__0(MeshFilter meshFilter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshFilter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.__c__DisplayClass33_0.NativeMethodInfoPtr__GetMeshFiltersToCombine_b__0_Internal_Boolean_MeshFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B988 RID: 47496 RVA: 0x0005AAFD File Offset: 0x00058CFD
			public __c__DisplayClass33_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700393B RID: 14651
			// (get) Token: 0x0600B989 RID: 47497 RVA: 0x002E0E34 File Offset: 0x002DF034
			// (set) Token: 0x0600B98A RID: 47498 RVA: 0x0005AB06 File Offset: 0x00058D06
			public unsafe Il2CppReferenceArray<MeshFilter> meshFilters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.__c__DisplayClass33_0.NativeFieldInfoPtr_meshFilters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshFilter>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.__c__DisplayClass33_0.NativeFieldInfoPtr_meshFilters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700393C RID: 14652
			// (get) Token: 0x0600B98B RID: 47499 RVA: 0x002E0E64 File Offset: 0x002DF064
			// (set) Token: 0x0600B98C RID: 47500 RVA: 0x0005AB25 File Offset: 0x00058D25
			public unsafe MeshCombiner __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshCombiner>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D27 RID: 32039
			private static readonly IntPtr NativeFieldInfoPtr_meshFilters;

			// Token: 0x04007D28 RID: 32040
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007D29 RID: 32041
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D2A RID: 32042
			private static readonly IntPtr NativeMethodInfoPtr__GetMeshFiltersToCombine_b__0_Internal_Boolean_MeshFilter_0;
		}

		// Token: 0x020007B0 RID: 1968
		[ObfuscatedName("MeshCombiner+<>c__DisplayClass33_1")]
		public sealed class __c__DisplayClass33_1 : Il2CppSystem.Object
		{
			// Token: 0x0600B98D RID: 47501 RVA: 0x002E0E94 File Offset: 0x002DF094
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_1()
			{
				Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "<>c__DisplayClass33_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_1>.NativeClassPtr);
				MeshCombiner.__c__DisplayClass33_1.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_1>.NativeClassPtr, "i");
				MeshCombiner.__c__DisplayClass33_1.NativeFieldInfoPtr_field_Public___c__DisplayClass33_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_1>.NativeClassPtr, "CS$<>8__locals1");
				MeshCombiner.__c__DisplayClass33_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_1>.NativeClassPtr, 100663593);
				MeshCombiner.__c__DisplayClass33_1.NativeMethodInfoPtr__GetMeshFiltersToCombine_b__2_Internal_Boolean_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_1>.NativeClassPtr, 100663594);
			}

			// Token: 0x0600B98E RID: 47502 RVA: 0x002E0F10 File Offset: 0x002DF110
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.__c__DisplayClass33_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B98F RID: 47503 RVA: 0x002E0F4C File Offset: 0x002DF14C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72810, XrefRangeEnd = 72816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetMeshFiltersToCombine_b__2(MeshFilter meshFilter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshFilter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.__c__DisplayClass33_1.NativeMethodInfoPtr__GetMeshFiltersToCombine_b__2_Internal_Boolean_MeshFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B990 RID: 47504 RVA: 0x0005AB44 File Offset: 0x00058D44
			public __c__DisplayClass33_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700393D RID: 14653
			// (get) Token: 0x0600B991 RID: 47505 RVA: 0x002E0F9C File Offset: 0x002DF19C
			// (set) Token: 0x0600B992 RID: 47506 RVA: 0x0005AB4D File Offset: 0x00058D4D
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.__c__DisplayClass33_1.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.__c__DisplayClass33_1.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x1700393E RID: 14654
			// (get) Token: 0x0600B993 RID: 47507 RVA: 0x002E0FC4 File Offset: 0x002DF1C4
			// (set) Token: 0x0600B994 RID: 47508 RVA: 0x0005AB68 File Offset: 0x00058D68
			public unsafe MeshCombiner.__c__DisplayClass33_0 field_Public___c__DisplayClass33_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.__c__DisplayClass33_1.NativeFieldInfoPtr_field_Public___c__DisplayClass33_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshCombiner.__c__DisplayClass33_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.__c__DisplayClass33_1.NativeFieldInfoPtr_field_Public___c__DisplayClass33_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D2B RID: 32043
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x04007D2C RID: 32044
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass33_0_0;

			// Token: 0x04007D2D RID: 32045
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D2E RID: 32046
			private static readonly IntPtr NativeMethodInfoPtr__GetMeshFiltersToCombine_b__2_Internal_Boolean_MeshFilter_0;
		}
	}
}

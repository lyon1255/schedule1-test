using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000147 RID: 327
	public class CharacterCustomizationCombiner : Il2CppSystem.Object
	{
		// Token: 0x06001B28 RID: 6952 RVA: 0x000C58B0 File Offset: 0x000C3AB0
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCustomizationCombiner()
		{
			Il2CppClassPointerStore<CharacterCustomizationCombiner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CharacterCustomizationCombiner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationCombiner>.NativeClassPtr);
			CharacterCustomizationCombiner.NativeFieldInfoPtr_bindPoses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner>.NativeClassPtr, "bindPoses");
			CharacterCustomizationCombiner.NativeFieldInfoPtr_LODMeshInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner>.NativeClassPtr, "LODMeshInstances");
			CharacterCustomizationCombiner.NativeFieldInfoPtr_currentCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner>.NativeClassPtr, "currentCharacter");
			CharacterCustomizationCombiner.NativeFieldInfoPtr_useExportToAnotherObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner>.NativeClassPtr, "useExportToAnotherObject");
			CharacterCustomizationCombiner.NativeFieldInfoPtr_BlendshapeTransferWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner>.NativeClassPtr, "BlendshapeTransferWork");
			CharacterCustomizationCombiner.NativeFieldInfoPtr__callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner>.NativeClassPtr, "_callback");
			CharacterCustomizationCombiner.NativeFieldInfoPtr_returnSkinnedMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner>.NativeClassPtr, "returnSkinnedMeshes");
			CharacterCustomizationCombiner.NativeMethodInfoPtr_MakeCombinedMeshes_Public_Static_List_1_SkinnedMeshRenderer_CharacterCustomization_GameObject_Single_Action_1_List_1_SkinnedMeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCombiner>.NativeClassPtr, 100666200);
			CharacterCustomizationCombiner.NativeMethodInfoPtr_BlendshapeTransfer_Private_Static_IEnumerator_MeshInstance_Single_SkinnedMeshRenderer_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCombiner>.NativeClassPtr, 100666201);
			CharacterCustomizationCombiner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCombiner>.NativeClassPtr, 100666202);
			CharacterCustomizationCombiner.NativeMethodInfoPtr_Method_Internal_Static_Void_SkinnedMeshRenderer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCombiner>.NativeClassPtr, 100666204);
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x000C59BC File Offset: 0x000C3BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99845, XrefRangeEnd = 100167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<SkinnedMeshRenderer> MakeCombinedMeshes(CharacterCustomization character, GameObject exportInCustomObject = null, float blendshapeAddDelay = 0.001f, Action<List<SkinnedMeshRenderer>> callback = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exportInCustomObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blendshapeAddDelay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCombiner.NativeMethodInfoPtr_MakeCombinedMeshes_Public_Static_List_1_SkinnedMeshRenderer_CharacterCustomization_GameObject_Single_Action_1_List_1_SkinnedMeshRenderer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SkinnedMeshRenderer>>(intPtr3) : null;
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x000C5A34 File Offset: 0x000C3C34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100173, RefRangeEnd = 100174, XrefRangeStart = 100167, XrefRangeEnd = 100173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator BlendshapeTransfer(CharacterCustomizationCombiner.MeshInstance meshInstance, float waitTime, SkinnedMeshRenderer smr, int lod, bool yieldUse = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshInstance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(smr);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lod;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yieldUse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCombiner.NativeMethodInfoPtr_BlendshapeTransfer_Private_Static_IEnumerator_MeshInstance_Single_SkinnedMeshRenderer_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x000C5AB4 File Offset: 0x000C3CB4
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCustomizationCombiner() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationCombiner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCombiner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x000C5AF0 File Offset: 0x000C3CF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100237, RefRangeEnd = 100238, XrefRangeStart = 100174, XrefRangeEnd = 100237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_SkinnedMeshRenderer_Int32_0(SkinnedMeshRenderer mesh, int LOD)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref LOD;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCombiner.NativeMethodInfoPtr_Method_Internal_Static_Void_SkinnedMeshRenderer_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x0000F54A File Offset: 0x0000D74A
		public CharacterCustomizationCombiner(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06001B2E RID: 6958 RVA: 0x000C5B34 File Offset: 0x000C3D34
		// (set) Token: 0x06001B2F RID: 6959 RVA: 0x0000F553 File Offset: 0x0000D753
		public unsafe static Il2CppStructArray<Matrix4x4> bindPoses
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CharacterCustomizationCombiner.NativeFieldInfoPtr_bindPoses, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharacterCustomizationCombiner.NativeFieldInfoPtr_bindPoses, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06001B30 RID: 6960 RVA: 0x000C5B5C File Offset: 0x000C3D5C
		// (set) Token: 0x06001B31 RID: 6961 RVA: 0x0000F565 File Offset: 0x0000D765
		public unsafe static List<CharacterCustomizationCombiner.MeshInstance> LODMeshInstances
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CharacterCustomizationCombiner.NativeFieldInfoPtr_LODMeshInstances, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CharacterCustomizationCombiner.MeshInstance>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharacterCustomizationCombiner.NativeFieldInfoPtr_LODMeshInstances, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06001B32 RID: 6962 RVA: 0x000C5B84 File Offset: 0x000C3D84
		// (set) Token: 0x06001B33 RID: 6963 RVA: 0x0000F577 File Offset: 0x0000D777
		public unsafe static CharacterCustomization currentCharacter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CharacterCustomizationCombiner.NativeFieldInfoPtr_currentCharacter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomization>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharacterCustomizationCombiner.NativeFieldInfoPtr_currentCharacter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06001B34 RID: 6964 RVA: 0x000C5BAC File Offset: 0x000C3DAC
		// (set) Token: 0x06001B35 RID: 6965 RVA: 0x0000F589 File Offset: 0x0000D789
		public unsafe static bool useExportToAnotherObject
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(CharacterCustomizationCombiner.NativeFieldInfoPtr_useExportToAnotherObject, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharacterCustomizationCombiner.NativeFieldInfoPtr_useExportToAnotherObject, (void*)(&value));
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06001B36 RID: 6966 RVA: 0x000C5BC8 File Offset: 0x000C3DC8
		// (set) Token: 0x06001B37 RID: 6967 RVA: 0x0000F597 File Offset: 0x0000D797
		public unsafe static bool BlendshapeTransferWork
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(CharacterCustomizationCombiner.NativeFieldInfoPtr_BlendshapeTransferWork, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharacterCustomizationCombiner.NativeFieldInfoPtr_BlendshapeTransferWork, (void*)(&value));
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06001B38 RID: 6968 RVA: 0x000C5BE4 File Offset: 0x000C3DE4
		// (set) Token: 0x06001B39 RID: 6969 RVA: 0x0000F5A5 File Offset: 0x0000D7A5
		public unsafe static Action<List<SkinnedMeshRenderer>> _callback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CharacterCustomizationCombiner.NativeFieldInfoPtr__callback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<List<SkinnedMeshRenderer>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharacterCustomizationCombiner.NativeFieldInfoPtr__callback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06001B3A RID: 6970 RVA: 0x000C5C0C File Offset: 0x000C3E0C
		// (set) Token: 0x06001B3B RID: 6971 RVA: 0x0000F5B7 File Offset: 0x0000D7B7
		public unsafe static List<SkinnedMeshRenderer> returnSkinnedMeshes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CharacterCustomizationCombiner.NativeFieldInfoPtr_returnSkinnedMeshes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharacterCustomizationCombiner.NativeFieldInfoPtr_returnSkinnedMeshes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011EC RID: 4588
		private static readonly IntPtr NativeFieldInfoPtr_bindPoses;

		// Token: 0x040011ED RID: 4589
		private static readonly IntPtr NativeFieldInfoPtr_LODMeshInstances;

		// Token: 0x040011EE RID: 4590
		private static readonly IntPtr NativeFieldInfoPtr_currentCharacter;

		// Token: 0x040011EF RID: 4591
		private static readonly IntPtr NativeFieldInfoPtr_useExportToAnotherObject;

		// Token: 0x040011F0 RID: 4592
		private static readonly IntPtr NativeFieldInfoPtr_BlendshapeTransferWork;

		// Token: 0x040011F1 RID: 4593
		private static readonly IntPtr NativeFieldInfoPtr__callback;

		// Token: 0x040011F2 RID: 4594
		private static readonly IntPtr NativeFieldInfoPtr_returnSkinnedMeshes;

		// Token: 0x040011F3 RID: 4595
		private static readonly IntPtr NativeMethodInfoPtr_MakeCombinedMeshes_Public_Static_List_1_SkinnedMeshRenderer_CharacterCustomization_GameObject_Single_Action_1_List_1_SkinnedMeshRenderer_0;

		// Token: 0x040011F4 RID: 4596
		private static readonly IntPtr NativeMethodInfoPtr_BlendshapeTransfer_Private_Static_IEnumerator_MeshInstance_Single_SkinnedMeshRenderer_Int32_Boolean_0;

		// Token: 0x040011F5 RID: 4597
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040011F6 RID: 4598
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_SkinnedMeshRenderer_Int32_0;

		// Token: 0x0200085D RID: 2141
		public class MeshInstance : Il2CppSystem.Object
		{
			// Token: 0x0600C08F RID: 49295 RVA: 0x002F11E4 File Offset: 0x002EF3E4
			// Note: this type is marked as 'beforefieldinit'.
			static MeshInstance()
			{
				Il2CppClassPointerStore<CharacterCustomizationCombiner.MeshInstance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomizationCombiner>.NativeClassPtr, "MeshInstance");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationCombiner.MeshInstance>.NativeClassPtr);
				CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combine_instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner.MeshInstance>.NativeClassPtr, "combine_instances");
				CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_unique_materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner.MeshInstance>.NativeClassPtr, "unique_materials");
				CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combined_new_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner.MeshInstance>.NativeClassPtr, "combined_new_mesh");
				CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combined_vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner.MeshInstance>.NativeClassPtr, "combined_vertices");
				CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combined_uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner.MeshInstance>.NativeClassPtr, "combined_uv");
				CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combined_uv2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner.MeshInstance>.NativeClassPtr, "combined_uv2");
				CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combined_uv3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner.MeshInstance>.NativeClassPtr, "combined_uv3");
				CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combined_uv4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner.MeshInstance>.NativeClassPtr, "combined_uv4");
				CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_normals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner.MeshInstance>.NativeClassPtr, "normals");
				CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_tangents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner.MeshInstance>.NativeClassPtr, "tangents");
				CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combined_submesh_indices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner.MeshInstance>.NativeClassPtr, "combined_submesh_indices");
				CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combined_bone_weights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner.MeshInstance>.NativeClassPtr, "combined_bone_weights");
				CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_blendShapeNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner.MeshInstance>.NativeClassPtr, "blendShapeNames");
				CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_blendShapeValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner.MeshInstance>.NativeClassPtr, "blendShapeValues");
				CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_vertex_offset_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner.MeshInstance>.NativeClassPtr, "vertex_offset_map");
				CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_vertex_index_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner.MeshInstance>.NativeClassPtr, "vertex_index_offset");
				CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_current_material_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner.MeshInstance>.NativeClassPtr, "current_material_index");
				CharacterCustomizationCombiner.MeshInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCombiner.MeshInstance>.NativeClassPtr, 100666205);
			}

			// Token: 0x0600C090 RID: 49296 RVA: 0x002F1378 File Offset: 0x002EF578
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 99712, RefRangeEnd = 99713, XrefRangeStart = 99616, XrefRangeEnd = 99712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MeshInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationCombiner.MeshInstance>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCombiner.MeshInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C091 RID: 49297 RVA: 0x0005E0CA File Offset: 0x0005C2CA
			public MeshInstance(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BF5 RID: 15349
			// (get) Token: 0x0600C092 RID: 49298 RVA: 0x002F13B4 File Offset: 0x002EF5B4
			// (set) Token: 0x0600C093 RID: 49299 RVA: 0x0005E0D3 File Offset: 0x0005C2D3
			public unsafe Dictionary<Material, List<CharacterCustomizationCombiner.CombineInstanceWithSM>> combine_instances
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combine_instances);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Material, List<CharacterCustomizationCombiner.CombineInstanceWithSM>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combine_instances), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BF6 RID: 15350
			// (get) Token: 0x0600C094 RID: 49300 RVA: 0x002F13E4 File Offset: 0x002EF5E4
			// (set) Token: 0x0600C095 RID: 49301 RVA: 0x0005E0F2 File Offset: 0x0005C2F2
			public unsafe List<Material> unique_materials
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_unique_materials);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Material>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_unique_materials), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BF7 RID: 15351
			// (get) Token: 0x0600C096 RID: 49302 RVA: 0x002F1414 File Offset: 0x002EF614
			// (set) Token: 0x0600C097 RID: 49303 RVA: 0x0005E111 File Offset: 0x0005C311
			public unsafe Mesh combined_new_mesh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combined_new_mesh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combined_new_mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BF8 RID: 15352
			// (get) Token: 0x0600C098 RID: 49304 RVA: 0x002F1444 File Offset: 0x002EF644
			// (set) Token: 0x0600C099 RID: 49305 RVA: 0x0005E130 File Offset: 0x0005C330
			public unsafe List<Vector3> combined_vertices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combined_vertices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combined_vertices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BF9 RID: 15353
			// (get) Token: 0x0600C09A RID: 49306 RVA: 0x002F1474 File Offset: 0x002EF674
			// (set) Token: 0x0600C09B RID: 49307 RVA: 0x0005E14F File Offset: 0x0005C34F
			public unsafe List<Vector2> combined_uv
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combined_uv);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combined_uv), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BFA RID: 15354
			// (get) Token: 0x0600C09C RID: 49308 RVA: 0x002F14A4 File Offset: 0x002EF6A4
			// (set) Token: 0x0600C09D RID: 49309 RVA: 0x0005E16E File Offset: 0x0005C36E
			public unsafe List<Vector2> combined_uv2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combined_uv2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combined_uv2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BFB RID: 15355
			// (get) Token: 0x0600C09E RID: 49310 RVA: 0x002F14D4 File Offset: 0x002EF6D4
			// (set) Token: 0x0600C09F RID: 49311 RVA: 0x0005E18D File Offset: 0x0005C38D
			public unsafe List<Vector2> combined_uv3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combined_uv3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combined_uv3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BFC RID: 15356
			// (get) Token: 0x0600C0A0 RID: 49312 RVA: 0x002F1504 File Offset: 0x002EF704
			// (set) Token: 0x0600C0A1 RID: 49313 RVA: 0x0005E1AC File Offset: 0x0005C3AC
			public unsafe List<Vector2> combined_uv4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combined_uv4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combined_uv4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BFD RID: 15357
			// (get) Token: 0x0600C0A2 RID: 49314 RVA: 0x002F1534 File Offset: 0x002EF734
			// (set) Token: 0x0600C0A3 RID: 49315 RVA: 0x0005E1CB File Offset: 0x0005C3CB
			public unsafe List<Vector3> normals
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_normals);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_normals), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BFE RID: 15358
			// (get) Token: 0x0600C0A4 RID: 49316 RVA: 0x002F1564 File Offset: 0x002EF764
			// (set) Token: 0x0600C0A5 RID: 49317 RVA: 0x0005E1EA File Offset: 0x0005C3EA
			public unsafe List<Vector4> tangents
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_tangents);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector4>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_tangents), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BFF RID: 15359
			// (get) Token: 0x0600C0A6 RID: 49318 RVA: 0x002F1594 File Offset: 0x002EF794
			// (set) Token: 0x0600C0A7 RID: 49319 RVA: 0x0005E209 File Offset: 0x0005C409
			public unsafe Dictionary<Material, List<int>> combined_submesh_indices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combined_submesh_indices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Material, List<int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combined_submesh_indices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C00 RID: 15360
			// (get) Token: 0x0600C0A8 RID: 49320 RVA: 0x002F15C4 File Offset: 0x002EF7C4
			// (set) Token: 0x0600C0A9 RID: 49321 RVA: 0x0005E228 File Offset: 0x0005C428
			public unsafe List<BoneWeight> combined_bone_weights
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combined_bone_weights);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BoneWeight>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_combined_bone_weights), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C01 RID: 15361
			// (get) Token: 0x0600C0AA RID: 49322 RVA: 0x002F15F4 File Offset: 0x002EF7F4
			// (set) Token: 0x0600C0AB RID: 49323 RVA: 0x0005E247 File Offset: 0x0005C447
			public unsafe List<string> blendShapeNames
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_blendShapeNames);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_blendShapeNames), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C02 RID: 15362
			// (get) Token: 0x0600C0AC RID: 49324 RVA: 0x002F1624 File Offset: 0x002EF824
			// (set) Token: 0x0600C0AD RID: 49325 RVA: 0x0005E266 File Offset: 0x0005C466
			public unsafe List<float> blendShapeValues
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_blendShapeValues);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_blendShapeValues), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C03 RID: 15363
			// (get) Token: 0x0600C0AE RID: 49326 RVA: 0x002F1654 File Offset: 0x002EF854
			// (set) Token: 0x0600C0AF RID: 49327 RVA: 0x0005E285 File Offset: 0x0005C485
			public unsafe Dictionary<Mesh, int> vertex_offset_map
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_vertex_offset_map);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Mesh, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_vertex_offset_map), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C04 RID: 15364
			// (get) Token: 0x0600C0B0 RID: 49328 RVA: 0x002F1684 File Offset: 0x002EF884
			// (set) Token: 0x0600C0B1 RID: 49329 RVA: 0x0005E2A4 File Offset: 0x0005C4A4
			public unsafe int vertex_index_offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_vertex_index_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_vertex_index_offset)) = value;
				}
			}

			// Token: 0x17003C05 RID: 15365
			// (get) Token: 0x0600C0B2 RID: 49330 RVA: 0x002F16AC File Offset: 0x002EF8AC
			// (set) Token: 0x0600C0B3 RID: 49331 RVA: 0x0005E2BF File Offset: 0x0005C4BF
			public unsafe int current_material_index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_current_material_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.MeshInstance.NativeFieldInfoPtr_current_material_index)) = value;
				}
			}

			// Token: 0x04008275 RID: 33397
			private static readonly IntPtr NativeFieldInfoPtr_combine_instances;

			// Token: 0x04008276 RID: 33398
			private static readonly IntPtr NativeFieldInfoPtr_unique_materials;

			// Token: 0x04008277 RID: 33399
			private static readonly IntPtr NativeFieldInfoPtr_combined_new_mesh;

			// Token: 0x04008278 RID: 33400
			private static readonly IntPtr NativeFieldInfoPtr_combined_vertices;

			// Token: 0x04008279 RID: 33401
			private static readonly IntPtr NativeFieldInfoPtr_combined_uv;

			// Token: 0x0400827A RID: 33402
			private static readonly IntPtr NativeFieldInfoPtr_combined_uv2;

			// Token: 0x0400827B RID: 33403
			private static readonly IntPtr NativeFieldInfoPtr_combined_uv3;

			// Token: 0x0400827C RID: 33404
			private static readonly IntPtr NativeFieldInfoPtr_combined_uv4;

			// Token: 0x0400827D RID: 33405
			private static readonly IntPtr NativeFieldInfoPtr_normals;

			// Token: 0x0400827E RID: 33406
			private static readonly IntPtr NativeFieldInfoPtr_tangents;

			// Token: 0x0400827F RID: 33407
			private static readonly IntPtr NativeFieldInfoPtr_combined_submesh_indices;

			// Token: 0x04008280 RID: 33408
			private static readonly IntPtr NativeFieldInfoPtr_combined_bone_weights;

			// Token: 0x04008281 RID: 33409
			private static readonly IntPtr NativeFieldInfoPtr_blendShapeNames;

			// Token: 0x04008282 RID: 33410
			private static readonly IntPtr NativeFieldInfoPtr_blendShapeValues;

			// Token: 0x04008283 RID: 33411
			private static readonly IntPtr NativeFieldInfoPtr_vertex_offset_map;

			// Token: 0x04008284 RID: 33412
			private static readonly IntPtr NativeFieldInfoPtr_vertex_index_offset;

			// Token: 0x04008285 RID: 33413
			private static readonly IntPtr NativeFieldInfoPtr_current_material_index;

			// Token: 0x04008286 RID: 33414
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200085E RID: 2142
		public sealed class CombineInstanceWithSM : ValueType
		{
			// Token: 0x0600C0B4 RID: 49332 RVA: 0x002F16D4 File Offset: 0x002EF8D4
			// Note: this type is marked as 'beforefieldinit'.
			static CombineInstanceWithSM()
			{
				Il2CppClassPointerStore<CharacterCustomizationCombiner.CombineInstanceWithSM>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomizationCombiner>.NativeClassPtr, "CombineInstanceWithSM");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationCombiner.CombineInstanceWithSM>.NativeClassPtr);
				CharacterCustomizationCombiner.CombineInstanceWithSM.NativeFieldInfoPtr_skinnedMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner.CombineInstanceWithSM>.NativeClassPtr, "skinnedMesh");
				CharacterCustomizationCombiner.CombineInstanceWithSM.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner.CombineInstanceWithSM>.NativeClassPtr, "instance");
			}

			// Token: 0x0600C0B5 RID: 49333 RVA: 0x0005E2DA File Offset: 0x0005C4DA
			public CombineInstanceWithSM(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C0B6 RID: 49334 RVA: 0x0005E2E3 File Offset: 0x0005C4E3
			public CombineInstanceWithSM() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationCombiner.CombineInstanceWithSM>.NativeClassPtr))
			{
			}

			// Token: 0x17003C06 RID: 15366
			// (get) Token: 0x0600C0B7 RID: 49335 RVA: 0x002F1728 File Offset: 0x002EF928
			// (set) Token: 0x0600C0B8 RID: 49336 RVA: 0x0005E2F5 File Offset: 0x0005C4F5
			public unsafe SkinnedMeshRenderer skinnedMesh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.CombineInstanceWithSM.NativeFieldInfoPtr_skinnedMesh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.CombineInstanceWithSM.NativeFieldInfoPtr_skinnedMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C07 RID: 15367
			// (get) Token: 0x0600C0B9 RID: 49337 RVA: 0x002F1758 File Offset: 0x002EF958
			// (set) Token: 0x0600C0BA RID: 49338 RVA: 0x0005E314 File Offset: 0x0005C514
			public unsafe CombineInstance instance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.CombineInstanceWithSM.NativeFieldInfoPtr_instance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.CombineInstanceWithSM.NativeFieldInfoPtr_instance)) = value;
				}
			}

			// Token: 0x04008287 RID: 33415
			private static readonly IntPtr NativeFieldInfoPtr_skinnedMesh;

			// Token: 0x04008288 RID: 33416
			private static readonly IntPtr NativeFieldInfoPtr_instance;
		}

		// Token: 0x0200085F RID: 2143
		public sealed class BlendWeightData : ValueType
		{
			// Token: 0x0600C0BB RID: 49339 RVA: 0x002F1780 File Offset: 0x002EF980
			// Note: this type is marked as 'beforefieldinit'.
			static BlendWeightData()
			{
				Il2CppClassPointerStore<CharacterCustomizationCombiner.BlendWeightData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomizationCombiner>.NativeClassPtr, "BlendWeightData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationCombiner.BlendWeightData>.NativeClassPtr);
				CharacterCustomizationCombiner.BlendWeightData.NativeFieldInfoPtr_deltaVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner.BlendWeightData>.NativeClassPtr, "deltaVerts");
				CharacterCustomizationCombiner.BlendWeightData.NativeFieldInfoPtr_deltaNormals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner.BlendWeightData>.NativeClassPtr, "deltaNormals");
				CharacterCustomizationCombiner.BlendWeightData.NativeFieldInfoPtr_deltaTangents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner.BlendWeightData>.NativeClassPtr, "deltaTangents");
			}

			// Token: 0x0600C0BC RID: 49340 RVA: 0x0005E32F File Offset: 0x0005C52F
			public BlendWeightData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C0BD RID: 49341 RVA: 0x0005E338 File Offset: 0x0005C538
			public BlendWeightData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationCombiner.BlendWeightData>.NativeClassPtr))
			{
			}

			// Token: 0x17003C08 RID: 15368
			// (get) Token: 0x0600C0BE RID: 49342 RVA: 0x002F17E8 File Offset: 0x002EF9E8
			// (set) Token: 0x0600C0BF RID: 49343 RVA: 0x0005E34A File Offset: 0x0005C54A
			public unsafe Il2CppStructArray<Vector3> deltaVerts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.BlendWeightData.NativeFieldInfoPtr_deltaVerts);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.BlendWeightData.NativeFieldInfoPtr_deltaVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C09 RID: 15369
			// (get) Token: 0x0600C0C0 RID: 49344 RVA: 0x002F1818 File Offset: 0x002EFA18
			// (set) Token: 0x0600C0C1 RID: 49345 RVA: 0x0005E369 File Offset: 0x0005C569
			public unsafe Il2CppStructArray<Vector3> deltaNormals
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.BlendWeightData.NativeFieldInfoPtr_deltaNormals);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.BlendWeightData.NativeFieldInfoPtr_deltaNormals), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C0A RID: 15370
			// (get) Token: 0x0600C0C2 RID: 49346 RVA: 0x002F1848 File Offset: 0x002EFA48
			// (set) Token: 0x0600C0C3 RID: 49347 RVA: 0x0005E388 File Offset: 0x0005C588
			public unsafe Il2CppStructArray<Vector3> deltaTangents
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.BlendWeightData.NativeFieldInfoPtr_deltaTangents);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner.BlendWeightData.NativeFieldInfoPtr_deltaTangents), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008289 RID: 33417
			private static readonly IntPtr NativeFieldInfoPtr_deltaVerts;

			// Token: 0x0400828A RID: 33418
			private static readonly IntPtr NativeFieldInfoPtr_deltaNormals;

			// Token: 0x0400828B RID: 33419
			private static readonly IntPtr NativeFieldInfoPtr_deltaTangents;
		}

		// Token: 0x02000860 RID: 2144
		[ObfuscatedName("AdvancedPeopleSystem.CharacterCustomizationCombiner+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C0C4 RID: 49348 RVA: 0x002F1878 File Offset: 0x002EFA78
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CharacterCustomizationCombiner.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomizationCombiner>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationCombiner.__c>.NativeClassPtr);
				CharacterCustomizationCombiner.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner.__c>.NativeClassPtr, "<>9");
				CharacterCustomizationCombiner.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner.__c>.NativeClassPtr, "<>9__11_0");
				CharacterCustomizationCombiner.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCombiner.__c>.NativeClassPtr, 100666207);
				CharacterCustomizationCombiner.__c.NativeMethodInfoPtr__BlendshapeTransfer_b__11_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCombiner.__c>.NativeClassPtr, 100666208);
			}

			// Token: 0x0600C0C5 RID: 49349 RVA: 0x002F18F4 File Offset: 0x002EFAF4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationCombiner.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCombiner.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C0C6 RID: 49350 RVA: 0x002F1930 File Offset: 0x002EFB30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99713, XrefRangeEnd = 99717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BlendshapeTransfer_b__11_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCombiner.__c.NativeMethodInfoPtr__BlendshapeTransfer_b__11_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C0C7 RID: 49351 RVA: 0x0005E3A7 File Offset: 0x0005C5A7
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C0B RID: 15371
			// (get) Token: 0x0600C0C8 RID: 49352 RVA: 0x002F196C File Offset: 0x002EFB6C
			// (set) Token: 0x0600C0C9 RID: 49353 RVA: 0x0005E3B0 File Offset: 0x0005C5B0
			public unsafe static CharacterCustomizationCombiner.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CharacterCustomizationCombiner.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationCombiner.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CharacterCustomizationCombiner.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C0C RID: 15372
			// (get) Token: 0x0600C0CA RID: 49354 RVA: 0x002F1994 File Offset: 0x002EFB94
			// (set) Token: 0x0600C0CB RID: 49355 RVA: 0x0005E3C2 File Offset: 0x0005C5C2
			public unsafe static Func<bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CharacterCustomizationCombiner.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CharacterCustomizationCombiner.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400828C RID: 33420
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400828D RID: 33421
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x0400828E RID: 33422
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400828F RID: 33423
			private static readonly IntPtr NativeMethodInfoPtr__BlendshapeTransfer_b__11_0_Internal_Boolean_0;
		}

		// Token: 0x02000861 RID: 2145
		[ObfuscatedName("AdvancedPeopleSystem.CharacterCustomizationCombiner+<BlendshapeTransfer>d__11")]
		public sealed class _BlendshapeTransfer_d__11 : Il2CppSystem.Object
		{
			// Token: 0x0600C0CC RID: 49356 RVA: 0x002F19BC File Offset: 0x002EFBBC
			// Note: this type is marked as 'beforefieldinit'.
			static _BlendshapeTransfer_d__11()
			{
				Il2CppClassPointerStore<CharacterCustomizationCombiner._BlendshapeTransfer_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomizationCombiner>.NativeClassPtr, "<BlendshapeTransfer>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationCombiner._BlendshapeTransfer_d__11>.NativeClassPtr);
				CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner._BlendshapeTransfer_d__11>.NativeClassPtr, "<>1__state");
				CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner._BlendshapeTransfer_d__11>.NativeClassPtr, "<>2__current");
				CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr_meshInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner._BlendshapeTransfer_d__11>.NativeClassPtr, "meshInstance");
				CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr_smr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner._BlendshapeTransfer_d__11>.NativeClassPtr, "smr");
				CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr_waitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner._BlendshapeTransfer_d__11>.NativeClassPtr, "waitTime");
				CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr_yieldUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner._BlendshapeTransfer_d__11>.NativeClassPtr, "yieldUse");
				CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr_lod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner._BlendshapeTransfer_d__11>.NativeClassPtr, "lod");
				CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr__characterSystem_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner._BlendshapeTransfer_d__11>.NativeClassPtr, "<characterSystem>5__2");
				CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr__bs_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCombiner._BlendshapeTransfer_d__11>.NativeClassPtr, "<bs>5__3");
				CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCombiner._BlendshapeTransfer_d__11>.NativeClassPtr, 100666209);
				CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCombiner._BlendshapeTransfer_d__11>.NativeClassPtr, 100666210);
				CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCombiner._BlendshapeTransfer_d__11>.NativeClassPtr, 100666211);
				CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCombiner._BlendshapeTransfer_d__11>.NativeClassPtr, 100666212);
				CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCombiner._BlendshapeTransfer_d__11>.NativeClassPtr, 100666213);
				CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCombiner._BlendshapeTransfer_d__11>.NativeClassPtr, 100666214);
			}

			// Token: 0x0600C0CD RID: 49357 RVA: 0x002F1B14 File Offset: 0x002EFD14
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BlendshapeTransfer_d__11(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationCombiner._BlendshapeTransfer_d__11>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C0CE RID: 49358 RVA: 0x002F1B5C File Offset: 0x002EFD5C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C0CF RID: 49359 RVA: 0x002F1B90 File Offset: 0x002EFD90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99717, XrefRangeEnd = 99840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003C16 RID: 15382
			// (get) Token: 0x0600C0D0 RID: 49360 RVA: 0x002F1BCC File Offset: 0x002EFDCC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C0D1 RID: 49361 RVA: 0x002F1C0C File Offset: 0x002EFE0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99840, XrefRangeEnd = 99845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003C17 RID: 15383
			// (get) Token: 0x0600C0D2 RID: 49362 RVA: 0x002F1C40 File Offset: 0x002EFE40
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C0D3 RID: 49363 RVA: 0x0005E3D4 File Offset: 0x0005C5D4
			public _BlendshapeTransfer_d__11(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C0D RID: 15373
			// (get) Token: 0x0600C0D4 RID: 49364 RVA: 0x002F1C80 File Offset: 0x002EFE80
			// (set) Token: 0x0600C0D5 RID: 49365 RVA: 0x0005E3DD File Offset: 0x0005C5DD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003C0E RID: 15374
			// (get) Token: 0x0600C0D6 RID: 49366 RVA: 0x002F1CA8 File Offset: 0x002EFEA8
			// (set) Token: 0x0600C0D7 RID: 49367 RVA: 0x0005E3F8 File Offset: 0x0005C5F8
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C0F RID: 15375
			// (get) Token: 0x0600C0D8 RID: 49368 RVA: 0x002F1CD8 File Offset: 0x002EFED8
			// (set) Token: 0x0600C0D9 RID: 49369 RVA: 0x0005E417 File Offset: 0x0005C617
			public unsafe CharacterCustomizationCombiner.MeshInstance meshInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr_meshInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationCombiner.MeshInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr_meshInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C10 RID: 15376
			// (get) Token: 0x0600C0DA RID: 49370 RVA: 0x002F1D08 File Offset: 0x002EFF08
			// (set) Token: 0x0600C0DB RID: 49371 RVA: 0x0005E436 File Offset: 0x0005C636
			public unsafe SkinnedMeshRenderer smr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr_smr);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr_smr), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C11 RID: 15377
			// (get) Token: 0x0600C0DC RID: 49372 RVA: 0x002F1D38 File Offset: 0x002EFF38
			// (set) Token: 0x0600C0DD RID: 49373 RVA: 0x0005E455 File Offset: 0x0005C655
			public unsafe float waitTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr_waitTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr_waitTime)) = value;
				}
			}

			// Token: 0x17003C12 RID: 15378
			// (get) Token: 0x0600C0DE RID: 49374 RVA: 0x002F1D60 File Offset: 0x002EFF60
			// (set) Token: 0x0600C0DF RID: 49375 RVA: 0x0005E470 File Offset: 0x0005C670
			public unsafe bool yieldUse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr_yieldUse);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr_yieldUse)) = value;
				}
			}

			// Token: 0x17003C13 RID: 15379
			// (get) Token: 0x0600C0E0 RID: 49376 RVA: 0x002F1D88 File Offset: 0x002EFF88
			// (set) Token: 0x0600C0E1 RID: 49377 RVA: 0x0005E48B File Offset: 0x0005C68B
			public unsafe int lod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr_lod);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr_lod)) = value;
				}
			}

			// Token: 0x17003C14 RID: 15380
			// (get) Token: 0x0600C0E2 RID: 49378 RVA: 0x002F1DB0 File Offset: 0x002EFFB0
			// (set) Token: 0x0600C0E3 RID: 49379 RVA: 0x0005E4A6 File Offset: 0x0005C6A6
			public unsafe CharacterCustomization _characterSystem_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr__characterSystem_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomization>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr__characterSystem_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C15 RID: 15381
			// (get) Token: 0x0600C0E4 RID: 49380 RVA: 0x002F1DE0 File Offset: 0x002EFFE0
			// (set) Token: 0x0600C0E5 RID: 49381 RVA: 0x0005E4C5 File Offset: 0x0005C6C5
			public unsafe int _bs_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr__bs_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCombiner._BlendshapeTransfer_d__11.NativeFieldInfoPtr__bs_5__3)) = value;
				}
			}

			// Token: 0x04008290 RID: 33424
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008291 RID: 33425
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008292 RID: 33426
			private static readonly IntPtr NativeFieldInfoPtr_meshInstance;

			// Token: 0x04008293 RID: 33427
			private static readonly IntPtr NativeFieldInfoPtr_smr;

			// Token: 0x04008294 RID: 33428
			private static readonly IntPtr NativeFieldInfoPtr_waitTime;

			// Token: 0x04008295 RID: 33429
			private static readonly IntPtr NativeFieldInfoPtr_yieldUse;

			// Token: 0x04008296 RID: 33430
			private static readonly IntPtr NativeFieldInfoPtr_lod;

			// Token: 0x04008297 RID: 33431
			private static readonly IntPtr NativeFieldInfoPtr__characterSystem_5__2;

			// Token: 0x04008298 RID: 33432
			private static readonly IntPtr NativeFieldInfoPtr__bs_5__3;

			// Token: 0x04008299 RID: 33433
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400829A RID: 33434
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400829B RID: 33435
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400829C RID: 33436
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400829D RID: 33437
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400829E RID: 33438
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

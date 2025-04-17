using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200007C RID: 124
	public class BeamGeometryAbstractBase : MonoBehaviour
	{
		// Token: 0x060008AD RID: 2221 RVA: 0x0008B320 File Offset: 0x00089520
		// Note: this type is marked as 'beforefieldinit'.
		static BeamGeometryAbstractBase()
		{
			Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "BeamGeometryAbstractBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr);
			BeamGeometryAbstractBase.NativeFieldInfoPtr__meshRenderer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, "<meshRenderer>k__BackingField");
			BeamGeometryAbstractBase.NativeFieldInfoPtr__meshFilter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, "<meshFilter>k__BackingField");
			BeamGeometryAbstractBase.NativeFieldInfoPtr__coneMesh_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, "<coneMesh>k__BackingField");
			BeamGeometryAbstractBase.NativeFieldInfoPtr_m_ColorGradientMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, "m_ColorGradientMatrix");
			BeamGeometryAbstractBase.NativeFieldInfoPtr_m_CustomMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, "m_CustomMaterial");
			BeamGeometryAbstractBase.NativeMethodInfoPtr_get_meshRenderer_Public_get_MeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100664225);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_set_meshRenderer_Protected_set_Void_MeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100664226);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_get_meshFilter_Public_get_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100664227);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_set_meshFilter_Protected_set_Void_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100664228);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_get_coneMesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100664229);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_set_coneMesh_Protected_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100664230);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_GetMaster_Protected_Abstract_Virtual_New_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100664231);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100664232);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100664233);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_DestroyInvalidOwner_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100664234);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_DestroyBeamGeometryGameObject_Public_Static_Void_BeamGeometryAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100664235);
			BeamGeometryAbstractBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100664236);
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x0008B4A4 File Offset: 0x000896A4
		// (set) Token: 0x060008AF RID: 2223 RVA: 0x0008B4E4 File Offset: 0x000896E4
		public unsafe MeshRenderer meshRenderer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_get_meshRenderer_Public_get_MeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_set_meshRenderer_Protected_set_Void_MeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x0008B528 File Offset: 0x00089728
		// (set) Token: 0x060008B1 RID: 2225 RVA: 0x0008B568 File Offset: 0x00089768
		public unsafe MeshFilter meshFilter
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_get_meshFilter_Public_get_MeshFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_set_meshFilter_Protected_set_Void_MeshFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x0008B5AC File Offset: 0x000897AC
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x0008B5EC File Offset: 0x000897EC
		public unsafe Mesh coneMesh
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_get_coneMesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_set_coneMesh_Protected_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0008B630 File Offset: 0x00089830
		[CallerCount(0)]
		public unsafe virtual VolumetricLightBeamAbstractBase GetMaster()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BeamGeometryAbstractBase.NativeMethodInfoPtr_GetMaster_Protected_Abstract_Virtual_New_VolumetricLightBeamAbstractBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamAbstractBase>(intPtr3) : null;
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x0008B67C File Offset: 0x0008987C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79558, XrefRangeEnd = 79570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0008B6B0 File Offset: 0x000898B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79570, XrefRangeEnd = 79578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x0008B6E4 File Offset: 0x000898E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyInvalidOwner()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_DestroyInvalidOwner_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x0008B718 File Offset: 0x00089918
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79586, RefRangeEnd = 79588, XrefRangeStart = 79578, XrefRangeEnd = 79586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyBeamGeometryGameObject(BeamGeometryAbstractBase beamGeom)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beamGeom);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_DestroyBeamGeometryGameObject_Public_Static_Void_BeamGeometryAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x0008B750 File Offset: 0x00089950
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BeamGeometryAbstractBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00006ACF File Offset: 0x00004CCF
		public BeamGeometryAbstractBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x0008B78C File Offset: 0x0008998C
		// (set) Token: 0x060008BC RID: 2236 RVA: 0x00006AD8 File Offset: 0x00004CD8
		public unsafe MeshRenderer _meshRenderer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr__meshRenderer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr__meshRenderer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x0008B7BC File Offset: 0x000899BC
		// (set) Token: 0x060008BE RID: 2238 RVA: 0x00006AF7 File Offset: 0x00004CF7
		public unsafe MeshFilter _meshFilter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr__meshFilter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr__meshFilter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x0008B7EC File Offset: 0x000899EC
		// (set) Token: 0x060008C0 RID: 2240 RVA: 0x00006B16 File Offset: 0x00004D16
		public unsafe Mesh _coneMesh_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr__coneMesh_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr__coneMesh_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x0008B81C File Offset: 0x00089A1C
		// (set) Token: 0x060008C2 RID: 2242 RVA: 0x00006B35 File Offset: 0x00004D35
		public unsafe Matrix4x4 m_ColorGradientMatrix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr_m_ColorGradientMatrix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr_m_ColorGradientMatrix)) = value;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x0008B844 File Offset: 0x00089A44
		// (set) Token: 0x060008C4 RID: 2244 RVA: 0x00006B50 File Offset: 0x00004D50
		public unsafe Material m_CustomMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr_m_CustomMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr_m_CustomMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeFieldInfoPtr__meshRenderer_k__BackingField;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeFieldInfoPtr__meshFilter_k__BackingField;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeFieldInfoPtr__coneMesh_k__BackingField;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorGradientMatrix;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomMaterial;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeMethodInfoPtr_get_meshRenderer_Public_get_MeshRenderer_0;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeMethodInfoPtr_set_meshRenderer_Protected_set_Void_MeshRenderer_0;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeMethodInfoPtr_get_meshFilter_Public_get_MeshFilter_0;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeMethodInfoPtr_set_meshFilter_Protected_set_Void_MeshFilter_0;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeMethodInfoPtr_get_coneMesh_Public_get_Mesh_0;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeMethodInfoPtr_set_coneMesh_Protected_set_Void_Mesh_0;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeMethodInfoPtr_GetMaster_Protected_Abstract_Virtual_New_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeMethodInfoPtr_DestroyInvalidOwner_Private_Void_0;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeMethodInfoPtr_DestroyBeamGeometryGameObject_Public_Static_Void_BeamGeometryAbstractBase_0;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

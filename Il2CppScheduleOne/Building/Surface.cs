using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004C3 RID: 1219
	public class Surface : MonoBehaviour
	{
		// Token: 0x06006AB9 RID: 27321 RVA: 0x001DC604 File Offset: 0x001DA804
		// Note: this type is marked as 'beforefieldinit'.
		static Surface()
		{
			Il2CppClassPointerStore<Surface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "Surface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Surface>.NativeClassPtr);
			Surface.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Surface>.NativeClassPtr, "<GUID>k__BackingField");
			Surface.NativeFieldInfoPtr_SurfaceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Surface>.NativeClassPtr, "SurfaceType");
			Surface.NativeFieldInfoPtr_ValidFaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Surface>.NativeClassPtr, "ValidFaces");
			Surface.NativeFieldInfoPtr_ParentProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Surface>.NativeClassPtr, "ParentProperty");
			Surface.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Surface>.NativeClassPtr, "BakedGUID");
			Surface.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676827);
			Surface.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676828);
			Surface.NativeMethodInfoPtr_get_Container_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676829);
			Surface.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676830);
			Surface.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676831);
			Surface.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676832);
			Surface.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676833);
			Surface.NativeMethodInfoPtr_GetRelativePosition_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676834);
			Surface.NativeMethodInfoPtr_GetRelativeRotation_Public_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676835);
			Surface.NativeMethodInfoPtr_IsFrontFace_Public_Boolean_Vector3_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676836);
			Surface.NativeMethodInfoPtr_IsPointValid_Public_Boolean_Vector3_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676837);
			Surface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676838);
		}

		// Token: 0x1700200B RID: 8203
		// (get) Token: 0x06006ABA RID: 27322 RVA: 0x001DC788 File Offset: 0x001DA988
		// (set) Token: 0x06006ABB RID: 27323 RVA: 0x001DC7C4 File Offset: 0x001DA9C4
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700200C RID: 8204
		// (get) Token: 0x06006ABC RID: 27324 RVA: 0x001DC804 File Offset: 0x001DAA04
		public unsafe Transform Container
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215150, XrefRangeEnd = 215152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_get_Container_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06006ABD RID: 27325 RVA: 0x001DC844 File Offset: 0x001DAA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215152, XrefRangeEnd = 215155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ABE RID: 27326 RVA: 0x001DC878 File Offset: 0x001DAA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215155, XrefRangeEnd = 215167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ABF RID: 27327 RVA: 0x001DC8AC File Offset: 0x001DAAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215167, XrefRangeEnd = 215196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Surface.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AC0 RID: 27328 RVA: 0x001DC8E8 File Offset: 0x001DAAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215196, XrefRangeEnd = 215200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AC1 RID: 27329 RVA: 0x001DC928 File Offset: 0x001DAB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215200, XrefRangeEnd = 215202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetRelativePosition(Vector3 worldPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_GetRelativePosition_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006AC2 RID: 27330 RVA: 0x001DC974 File Offset: 0x001DAB74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215205, RefRangeEnd = 215206, XrefRangeStart = 215202, XrefRangeEnd = 215205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quaternion GetRelativeRotation(Quaternion worldRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_GetRelativeRotation_Public_Quaternion_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006AC3 RID: 27331 RVA: 0x001DC9C0 File Offset: 0x001DABC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215206, XrefRangeEnd = 215208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsFrontFace(Vector3 point, Collider collider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_IsFrontFace_Public_Boolean_Vector3_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006AC4 RID: 27332 RVA: 0x001DCA1C File Offset: 0x001DAC1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 215246, RefRangeEnd = 215248, XrefRangeStart = 215208, XrefRangeEnd = 215246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointValid(Vector3 point, Collider hitCollider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hitCollider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_IsPointValid_Public_Boolean_Vector3_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006AC5 RID: 27333 RVA: 0x001DCA78 File Offset: 0x001DAC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215248, XrefRangeEnd = 215265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Surface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Surface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AC6 RID: 27334 RVA: 0x0003276A File Offset: 0x0003096A
		public Surface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002006 RID: 8198
		// (get) Token: 0x06006AC7 RID: 27335 RVA: 0x001DCAB4 File Offset: 0x001DACB4
		// (set) Token: 0x06006AC8 RID: 27336 RVA: 0x00032773 File Offset: 0x00030973
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17002007 RID: 8199
		// (get) Token: 0x06006AC9 RID: 27337 RVA: 0x001DCADC File Offset: 0x001DACDC
		// (set) Token: 0x06006ACA RID: 27338 RVA: 0x0003278E File Offset: 0x0003098E
		public unsafe Surface.ESurfaceType SurfaceType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_SurfaceType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_SurfaceType)) = value;
			}
		}

		// Token: 0x17002008 RID: 8200
		// (get) Token: 0x06006ACB RID: 27339 RVA: 0x001DCB04 File Offset: 0x001DAD04
		// (set) Token: 0x06006ACC RID: 27340 RVA: 0x000327A9 File Offset: 0x000309A9
		public unsafe List<Surface.EFace> ValidFaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_ValidFaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Surface.EFace>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_ValidFaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002009 RID: 8201
		// (get) Token: 0x06006ACD RID: 27341 RVA: 0x001DCB34 File Offset: 0x001DAD34
		// (set) Token: 0x06006ACE RID: 27342 RVA: 0x000327C8 File Offset: 0x000309C8
		public unsafe Property ParentProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_ParentProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_ParentProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700200A RID: 8202
		// (get) Token: 0x06006ACF RID: 27343 RVA: 0x001DCB64 File Offset: 0x001DAD64
		// (set) Token: 0x06006AD0 RID: 27344 RVA: 0x000327E7 File Offset: 0x000309E7
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400490A RID: 18698
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x0400490B RID: 18699
		private static readonly IntPtr NativeFieldInfoPtr_SurfaceType;

		// Token: 0x0400490C RID: 18700
		private static readonly IntPtr NativeFieldInfoPtr_ValidFaces;

		// Token: 0x0400490D RID: 18701
		private static readonly IntPtr NativeFieldInfoPtr_ParentProperty;

		// Token: 0x0400490E RID: 18702
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x0400490F RID: 18703
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04004910 RID: 18704
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04004911 RID: 18705
		private static readonly IntPtr NativeMethodInfoPtr_get_Container_Public_get_Transform_0;

		// Token: 0x04004912 RID: 18706
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateGUID_Public_Void_0;

		// Token: 0x04004913 RID: 18707
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04004914 RID: 18708
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004915 RID: 18709
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04004916 RID: 18710
		private static readonly IntPtr NativeMethodInfoPtr_GetRelativePosition_Public_Vector3_Vector3_0;

		// Token: 0x04004917 RID: 18711
		private static readonly IntPtr NativeMethodInfoPtr_GetRelativeRotation_Public_Quaternion_Quaternion_0;

		// Token: 0x04004918 RID: 18712
		private static readonly IntPtr NativeMethodInfoPtr_IsFrontFace_Public_Boolean_Vector3_Collider_0;

		// Token: 0x04004919 RID: 18713
		private static readonly IntPtr NativeMethodInfoPtr_IsPointValid_Public_Boolean_Vector3_Collider_0;

		// Token: 0x0400491A RID: 18714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A56 RID: 2646
		[OriginalName("Assembly-CSharp.dll", "", "ESurfaceType")]
		public enum ESurfaceType
		{
			// Token: 0x04008C9B RID: 35995
			Wall,
			// Token: 0x04008C9C RID: 35996
			Roof
		}

		// Token: 0x02000A57 RID: 2647
		[OriginalName("Assembly-CSharp.dll", "", "EFace")]
		public enum EFace
		{
			// Token: 0x04008C9E RID: 35998
			Front,
			// Token: 0x04008C9F RID: 35999
			Back,
			// Token: 0x04008CA0 RID: 36000
			Top,
			// Token: 0x04008CA1 RID: 36001
			Bottom,
			// Token: 0x04008CA2 RID: 36002
			Left,
			// Token: 0x04008CA3 RID: 36003
			Right
		}
	}
}

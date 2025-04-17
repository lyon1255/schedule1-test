using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004C0 RID: 1216
	public class BuildUpdate_Surface : BuildUpdate_Base
	{
		// Token: 0x06006A8F RID: 27279 RVA: 0x001DBE20 File Offset: 0x001DA020
		// Note: this type is marked as 'beforefieldinit'.
		static BuildUpdate_Surface()
		{
			Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildUpdate_Surface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr);
			BuildUpdate_Surface.NativeFieldInfoPtr_GhostModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "GhostModel");
			BuildUpdate_Surface.NativeFieldInfoPtr_BuildableItemClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "BuildableItemClass");
			BuildUpdate_Surface.NativeFieldInfoPtr_ItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "ItemInstance");
			BuildUpdate_Surface.NativeFieldInfoPtr_CurrentRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "CurrentRotation");
			BuildUpdate_Surface.NativeFieldInfoPtr_DetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "DetectionMask");
			BuildUpdate_Surface.NativeFieldInfoPtr_validPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "validPosition");
			BuildUpdate_Surface.NativeFieldInfoPtr_currentGhostMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "currentGhostMaterial");
			BuildUpdate_Surface.NativeFieldInfoPtr_hoveredValidSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "hoveredValidSurface");
			BuildUpdate_Surface.NativeMethodInfoPtr_get_detectionRange_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676813);
			BuildUpdate_Surface.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676814);
			BuildUpdate_Surface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676815);
			BuildUpdate_Surface.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676816);
			BuildUpdate_Surface.NativeMethodInfoPtr_PositionObjectInFrontOfPlayer_Protected_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676817);
			BuildUpdate_Surface.NativeMethodInfoPtr_IsSurfaceValidForItem_Private_Boolean_Surface_Collider_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676818);
			BuildUpdate_Surface.NativeMethodInfoPtr_CheckRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676819);
			BuildUpdate_Surface.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676820);
			BuildUpdate_Surface.NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676821);
			BuildUpdate_Surface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676822);
		}

		// Token: 0x17002002 RID: 8194
		// (get) Token: 0x06006A90 RID: 27280 RVA: 0x001DBFB8 File Offset: 0x001DA1B8
		public unsafe float detectionRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Surface.NativeMethodInfoPtr_get_detectionRange_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006A91 RID: 27281 RVA: 0x001DBFF4 File Offset: 0x001DA1F4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 38034, RefRangeEnd = 38039, XrefRangeStart = 38034, XrefRangeEnd = 38039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Surface.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A92 RID: 27282 RVA: 0x001DC030 File Offset: 0x001DA230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214867, XrefRangeEnd = 214885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Surface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A93 RID: 27283 RVA: 0x001DC06C File Offset: 0x001DA26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214885, XrefRangeEnd = 214977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Surface.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A94 RID: 27284 RVA: 0x001DC0A8 File Offset: 0x001DA2A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215037, RefRangeEnd = 215038, XrefRangeStart = 214977, XrefRangeEnd = 215037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PositionObjectInFrontOfPlayer(float dist, bool sanitizeForward)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dist;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sanitizeForward;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Surface.NativeMethodInfoPtr_PositionObjectInFrontOfPlayer_Protected_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A95 RID: 27285 RVA: 0x001DC0F4 File Offset: 0x001DA2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215038, XrefRangeEnd = 215050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSurfaceValidForItem(Surface surface, Collider hitCollider, Vector3 hitPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(surface);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hitCollider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Surface.NativeMethodInfoPtr_IsSurfaceValidForItem_Private_Boolean_Surface_Collider_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006A96 RID: 27286 RVA: 0x001DC164 File Offset: 0x001DA364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215050, XrefRangeEnd = 215063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Surface.NativeMethodInfoPtr_CheckRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A97 RID: 27287 RVA: 0x001DC198 File Offset: 0x001DA398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215079, RefRangeEnd = 215080, XrefRangeStart = 215063, XrefRangeEnd = 215079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Surface.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A98 RID: 27288 RVA: 0x001DC1CC File Offset: 0x001DA3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215080, XrefRangeEnd = 215115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Place()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Surface.NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A99 RID: 27289 RVA: 0x001DC208 File Offset: 0x001DA408
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19449, RefRangeEnd = 19463, XrefRangeStart = 19449, XrefRangeEnd = 19463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildUpdate_Surface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Surface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A9A RID: 27290 RVA: 0x000325D5 File Offset: 0x000307D5
		public BuildUpdate_Surface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FFA RID: 8186
		// (get) Token: 0x06006A9B RID: 27291 RVA: 0x001DC244 File Offset: 0x001DA444
		// (set) Token: 0x06006A9C RID: 27292 RVA: 0x000325DE File Offset: 0x000307DE
		public unsafe GameObject GhostModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_GhostModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_GhostModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FFB RID: 8187
		// (get) Token: 0x06006A9D RID: 27293 RVA: 0x001DC274 File Offset: 0x001DA474
		// (set) Token: 0x06006A9E RID: 27294 RVA: 0x000325FD File Offset: 0x000307FD
		public unsafe SurfaceItem BuildableItemClass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_BuildableItemClass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SurfaceItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_BuildableItemClass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FFC RID: 8188
		// (get) Token: 0x06006A9F RID: 27295 RVA: 0x001DC2A4 File Offset: 0x001DA4A4
		// (set) Token: 0x06006AA0 RID: 27296 RVA: 0x0003261C File Offset: 0x0003081C
		public unsafe ItemInstance ItemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_ItemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_ItemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FFD RID: 8189
		// (get) Token: 0x06006AA1 RID: 27297 RVA: 0x001DC2D4 File Offset: 0x001DA4D4
		// (set) Token: 0x06006AA2 RID: 27298 RVA: 0x0003263B File Offset: 0x0003083B
		public unsafe float CurrentRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_CurrentRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_CurrentRotation)) = value;
			}
		}

		// Token: 0x17001FFE RID: 8190
		// (get) Token: 0x06006AA3 RID: 27299 RVA: 0x001DC2FC File Offset: 0x001DA4FC
		// (set) Token: 0x06006AA4 RID: 27300 RVA: 0x00032656 File Offset: 0x00030856
		public unsafe LayerMask DetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_DetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_DetectionMask)) = value;
			}
		}

		// Token: 0x17001FFF RID: 8191
		// (get) Token: 0x06006AA5 RID: 27301 RVA: 0x001DC324 File Offset: 0x001DA524
		// (set) Token: 0x06006AA6 RID: 27302 RVA: 0x00032671 File Offset: 0x00030871
		public unsafe bool validPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_validPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_validPosition)) = value;
			}
		}

		// Token: 0x17002000 RID: 8192
		// (get) Token: 0x06006AA7 RID: 27303 RVA: 0x001DC34C File Offset: 0x001DA54C
		// (set) Token: 0x06006AA8 RID: 27304 RVA: 0x0003268C File Offset: 0x0003088C
		public unsafe Material currentGhostMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_currentGhostMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_currentGhostMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002001 RID: 8193
		// (get) Token: 0x06006AA9 RID: 27305 RVA: 0x001DC37C File Offset: 0x001DA57C
		// (set) Token: 0x06006AAA RID: 27306 RVA: 0x000326AB File Offset: 0x000308AB
		public unsafe Surface hoveredValidSurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_hoveredValidSurface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Surface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_hoveredValidSurface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040048F1 RID: 18673
		private static readonly IntPtr NativeFieldInfoPtr_GhostModel;

		// Token: 0x040048F2 RID: 18674
		private static readonly IntPtr NativeFieldInfoPtr_BuildableItemClass;

		// Token: 0x040048F3 RID: 18675
		private static readonly IntPtr NativeFieldInfoPtr_ItemInstance;

		// Token: 0x040048F4 RID: 18676
		private static readonly IntPtr NativeFieldInfoPtr_CurrentRotation;

		// Token: 0x040048F5 RID: 18677
		private static readonly IntPtr NativeFieldInfoPtr_DetectionMask;

		// Token: 0x040048F6 RID: 18678
		private static readonly IntPtr NativeFieldInfoPtr_validPosition;

		// Token: 0x040048F7 RID: 18679
		private static readonly IntPtr NativeFieldInfoPtr_currentGhostMaterial;

		// Token: 0x040048F8 RID: 18680
		private static readonly IntPtr NativeFieldInfoPtr_hoveredValidSurface;

		// Token: 0x040048F9 RID: 18681
		private static readonly IntPtr NativeMethodInfoPtr_get_detectionRange_Private_get_Single_0;

		// Token: 0x040048FA RID: 18682
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040048FB RID: 18683
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040048FC RID: 18684
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040048FD RID: 18685
		private static readonly IntPtr NativeMethodInfoPtr_PositionObjectInFrontOfPlayer_Protected_Void_Single_Boolean_0;

		// Token: 0x040048FE RID: 18686
		private static readonly IntPtr NativeMethodInfoPtr_IsSurfaceValidForItem_Private_Boolean_Surface_Collider_Vector3_0;

		// Token: 0x040048FF RID: 18687
		private static readonly IntPtr NativeMethodInfoPtr_CheckRotation_Protected_Void_0;

		// Token: 0x04004900 RID: 18688
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0;

		// Token: 0x04004901 RID: 18689
		private static readonly IntPtr NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0;

		// Token: 0x04004902 RID: 18690
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

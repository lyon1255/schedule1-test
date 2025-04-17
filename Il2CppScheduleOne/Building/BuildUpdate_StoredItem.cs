using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004BF RID: 1215
	public class BuildUpdate_StoredItem : BuildUpdate_Base
	{
		// Token: 0x06006A69 RID: 27241 RVA: 0x001DB7B4 File Offset: 0x001D99B4
		// Note: this type is marked as 'beforefieldinit'.
		static BuildUpdate_StoredItem()
		{
			Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildUpdate_StoredItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr);
			BuildUpdate_StoredItem.NativeFieldInfoPtr_itemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "itemInstance");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_ghostModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "ghostModel");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_storedItemClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "storedItemClass");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_bestIntersection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "bestIntersection");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_detectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "detectionRange");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_detectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "detectionMask");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_storedItemHoldDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "storedItemHoldDistance");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_currentRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "currentRotation");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_validPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "validPosition");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_currentGhostMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "currentGhostMaterial");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_mouseUpSinceStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "mouseUpSinceStart");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_mouseUpSincePlace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "mouseUpSincePlace");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_positionDuringLastValidPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "positionDuringLastValidPosition");
			BuildUpdate_StoredItem.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100676802);
			BuildUpdate_StoredItem.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100676803);
			BuildUpdate_StoredItem.NativeMethodInfoPtr_CheckRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100676804);
			BuildUpdate_StoredItem.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100676805);
			BuildUpdate_StoredItem.NativeMethodInfoPtr_CheckGridIntersections_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100676806);
			BuildUpdate_StoredItem.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100676807);
			BuildUpdate_StoredItem.NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100676808);
			BuildUpdate_StoredItem.NativeMethodInfoPtr_PostPlace_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100676809);
			BuildUpdate_StoredItem.NativeMethodInfoPtr_GetOriginCoordinate_Protected_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100676810);
			BuildUpdate_StoredItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100676811);
		}

		// Token: 0x06006A6A RID: 27242 RVA: 0x001DB9B0 File Offset: 0x001D9BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214575, XrefRangeEnd = 214589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_StoredItem.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A6B RID: 27243 RVA: 0x001DB9EC File Offset: 0x001D9BEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214648, RefRangeEnd = 214649, XrefRangeStart = 214589, XrefRangeEnd = 214648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_StoredItem.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A6C RID: 27244 RVA: 0x001DBA28 File Offset: 0x001D9C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214649, XrefRangeEnd = 214656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_StoredItem.NativeMethodInfoPtr_CheckRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A6D RID: 27245 RVA: 0x001DBA5C File Offset: 0x001D9C5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214666, RefRangeEnd = 214667, XrefRangeStart = 214656, XrefRangeEnd = 214666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_StoredItem.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A6E RID: 27246 RVA: 0x001DBA90 File Offset: 0x001D9C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214667, XrefRangeEnd = 214795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckGridIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_StoredItem.NativeMethodInfoPtr_CheckGridIntersections_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A6F RID: 27247 RVA: 0x001DBACC File Offset: 0x001D9CCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 214811, RefRangeEnd = 214813, XrefRangeStart = 214795, XrefRangeEnd = 214811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_StoredItem.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A70 RID: 27248 RVA: 0x001DBB00 File Offset: 0x001D9D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214813, XrefRangeEnd = 214847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Place()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_StoredItem.NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A71 RID: 27249 RVA: 0x001DBB3C File Offset: 0x001D9D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214847, XrefRangeEnd = 214854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PostPlace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_StoredItem.NativeMethodInfoPtr_PostPlace_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A72 RID: 27250 RVA: 0x001DBB78 File Offset: 0x001D9D78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 214862, RefRangeEnd = 214864, XrefRangeStart = 214854, XrefRangeEnd = 214862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetOriginCoordinate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_StoredItem.NativeMethodInfoPtr_GetOriginCoordinate_Protected_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006A73 RID: 27251 RVA: 0x001DBBB4 File Offset: 0x001D9DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214864, XrefRangeEnd = 214867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildUpdate_StoredItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_StoredItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A74 RID: 27252 RVA: 0x00032459 File Offset: 0x00030659
		public BuildUpdate_StoredItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FED RID: 8173
		// (get) Token: 0x06006A75 RID: 27253 RVA: 0x001DBBF0 File Offset: 0x001D9DF0
		// (set) Token: 0x06006A76 RID: 27254 RVA: 0x00032462 File Offset: 0x00030662
		public unsafe StorableItemInstance itemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_itemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_itemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FEE RID: 8174
		// (get) Token: 0x06006A77 RID: 27255 RVA: 0x001DBC20 File Offset: 0x001D9E20
		// (set) Token: 0x06006A78 RID: 27256 RVA: 0x00032481 File Offset: 0x00030681
		public unsafe GameObject ghostModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_ghostModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_ghostModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FEF RID: 8175
		// (get) Token: 0x06006A79 RID: 27257 RVA: 0x001DBC50 File Offset: 0x001D9E50
		// (set) Token: 0x06006A7A RID: 27258 RVA: 0x000324A0 File Offset: 0x000306A0
		public unsafe StoredItem storedItemClass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_storedItemClass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_storedItemClass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF0 RID: 8176
		// (get) Token: 0x06006A7B RID: 27259 RVA: 0x001DBC80 File Offset: 0x001D9E80
		// (set) Token: 0x06006A7C RID: 27260 RVA: 0x000324BF File Offset: 0x000306BF
		public unsafe BuildUpdate_StoredItem.StorageTileIntersection bestIntersection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_bestIntersection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildUpdate_StoredItem.StorageTileIntersection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_bestIntersection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF1 RID: 8177
		// (get) Token: 0x06006A7D RID: 27261 RVA: 0x001DBCB0 File Offset: 0x001D9EB0
		// (set) Token: 0x06006A7E RID: 27262 RVA: 0x000324DE File Offset: 0x000306DE
		public unsafe float detectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_detectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_detectionRange)) = value;
			}
		}

		// Token: 0x17001FF2 RID: 8178
		// (get) Token: 0x06006A7F RID: 27263 RVA: 0x001DBCD8 File Offset: 0x001D9ED8
		// (set) Token: 0x06006A80 RID: 27264 RVA: 0x000324F9 File Offset: 0x000306F9
		public unsafe LayerMask detectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_detectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_detectionMask)) = value;
			}
		}

		// Token: 0x17001FF3 RID: 8179
		// (get) Token: 0x06006A81 RID: 27265 RVA: 0x001DBD00 File Offset: 0x001D9F00
		// (set) Token: 0x06006A82 RID: 27266 RVA: 0x00032514 File Offset: 0x00030714
		public unsafe float storedItemHoldDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_storedItemHoldDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_storedItemHoldDistance)) = value;
			}
		}

		// Token: 0x17001FF4 RID: 8180
		// (get) Token: 0x06006A83 RID: 27267 RVA: 0x001DBD28 File Offset: 0x001D9F28
		// (set) Token: 0x06006A84 RID: 27268 RVA: 0x0003252F File Offset: 0x0003072F
		public unsafe float currentRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_currentRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_currentRotation)) = value;
			}
		}

		// Token: 0x17001FF5 RID: 8181
		// (get) Token: 0x06006A85 RID: 27269 RVA: 0x001DBD50 File Offset: 0x001D9F50
		// (set) Token: 0x06006A86 RID: 27270 RVA: 0x0003254A File Offset: 0x0003074A
		public unsafe bool validPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_validPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_validPosition)) = value;
			}
		}

		// Token: 0x17001FF6 RID: 8182
		// (get) Token: 0x06006A87 RID: 27271 RVA: 0x001DBD78 File Offset: 0x001D9F78
		// (set) Token: 0x06006A88 RID: 27272 RVA: 0x00032565 File Offset: 0x00030765
		public unsafe Material currentGhostMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_currentGhostMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_currentGhostMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF7 RID: 8183
		// (get) Token: 0x06006A89 RID: 27273 RVA: 0x001DBDA8 File Offset: 0x001D9FA8
		// (set) Token: 0x06006A8A RID: 27274 RVA: 0x00032584 File Offset: 0x00030784
		public unsafe bool mouseUpSinceStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_mouseUpSinceStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_mouseUpSinceStart)) = value;
			}
		}

		// Token: 0x17001FF8 RID: 8184
		// (get) Token: 0x06006A8B RID: 27275 RVA: 0x001DBDD0 File Offset: 0x001D9FD0
		// (set) Token: 0x06006A8C RID: 27276 RVA: 0x0003259F File Offset: 0x0003079F
		public unsafe bool mouseUpSincePlace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_mouseUpSincePlace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_mouseUpSincePlace)) = value;
			}
		}

		// Token: 0x17001FF9 RID: 8185
		// (get) Token: 0x06006A8D RID: 27277 RVA: 0x001DBDF8 File Offset: 0x001D9FF8
		// (set) Token: 0x06006A8E RID: 27278 RVA: 0x000325BA File Offset: 0x000307BA
		public unsafe Vector3 positionDuringLastValidPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_positionDuringLastValidPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_positionDuringLastValidPosition)) = value;
			}
		}

		// Token: 0x040048DA RID: 18650
		private static readonly IntPtr NativeFieldInfoPtr_itemInstance;

		// Token: 0x040048DB RID: 18651
		private static readonly IntPtr NativeFieldInfoPtr_ghostModel;

		// Token: 0x040048DC RID: 18652
		private static readonly IntPtr NativeFieldInfoPtr_storedItemClass;

		// Token: 0x040048DD RID: 18653
		private static readonly IntPtr NativeFieldInfoPtr_bestIntersection;

		// Token: 0x040048DE RID: 18654
		private static readonly IntPtr NativeFieldInfoPtr_detectionRange;

		// Token: 0x040048DF RID: 18655
		private static readonly IntPtr NativeFieldInfoPtr_detectionMask;

		// Token: 0x040048E0 RID: 18656
		private static readonly IntPtr NativeFieldInfoPtr_storedItemHoldDistance;

		// Token: 0x040048E1 RID: 18657
		private static readonly IntPtr NativeFieldInfoPtr_currentRotation;

		// Token: 0x040048E2 RID: 18658
		private static readonly IntPtr NativeFieldInfoPtr_validPosition;

		// Token: 0x040048E3 RID: 18659
		private static readonly IntPtr NativeFieldInfoPtr_currentGhostMaterial;

		// Token: 0x040048E4 RID: 18660
		private static readonly IntPtr NativeFieldInfoPtr_mouseUpSinceStart;

		// Token: 0x040048E5 RID: 18661
		private static readonly IntPtr NativeFieldInfoPtr_mouseUpSincePlace;

		// Token: 0x040048E6 RID: 18662
		private static readonly IntPtr NativeFieldInfoPtr_positionDuringLastValidPosition;

		// Token: 0x040048E7 RID: 18663
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040048E8 RID: 18664
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040048E9 RID: 18665
		private static readonly IntPtr NativeMethodInfoPtr_CheckRotation_Protected_Void_0;

		// Token: 0x040048EA RID: 18666
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRotation_Protected_Void_0;

		// Token: 0x040048EB RID: 18667
		private static readonly IntPtr NativeMethodInfoPtr_CheckGridIntersections_Protected_Virtual_New_Void_0;

		// Token: 0x040048EC RID: 18668
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0;

		// Token: 0x040048ED RID: 18669
		private static readonly IntPtr NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0;

		// Token: 0x040048EE RID: 18670
		private static readonly IntPtr NativeMethodInfoPtr_PostPlace_Protected_Virtual_New_Void_0;

		// Token: 0x040048EF RID: 18671
		private static readonly IntPtr NativeMethodInfoPtr_GetOriginCoordinate_Protected_Vector2_0;

		// Token: 0x040048F0 RID: 18672
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A55 RID: 2645
		public class StorageTileIntersection : Il2CppSystem.Object
		{
			// Token: 0x0600D05A RID: 53338 RVA: 0x0031F9FC File Offset: 0x0031DBFC
			// Note: this type is marked as 'beforefieldinit'.
			static StorageTileIntersection()
			{
				Il2CppClassPointerStore<BuildUpdate_StoredItem.StorageTileIntersection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "StorageTileIntersection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_StoredItem.StorageTileIntersection>.NativeClassPtr);
				BuildUpdate_StoredItem.StorageTileIntersection.NativeFieldInfoPtr_footprintTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem.StorageTileIntersection>.NativeClassPtr, "footprintTile");
				BuildUpdate_StoredItem.StorageTileIntersection.NativeFieldInfoPtr_storageTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem.StorageTileIntersection>.NativeClassPtr, "storageTile");
				BuildUpdate_StoredItem.StorageTileIntersection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem.StorageTileIntersection>.NativeClassPtr, 100676812);
			}

			// Token: 0x0600D05B RID: 53339 RVA: 0x0031FA64 File Offset: 0x0031DC64
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StorageTileIntersection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_StoredItem.StorageTileIntersection>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_StoredItem.StorageTileIntersection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D05C RID: 53340 RVA: 0x00065666 File Offset: 0x00063866
			public StorageTileIntersection(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040B5 RID: 16565
			// (get) Token: 0x0600D05D RID: 53341 RVA: 0x0031FAA0 File Offset: 0x0031DCA0
			// (set) Token: 0x0600D05E RID: 53342 RVA: 0x0006566F File Offset: 0x0006386F
			public unsafe FootprintTile footprintTile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.StorageTileIntersection.NativeFieldInfoPtr_footprintTile);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.StorageTileIntersection.NativeFieldInfoPtr_footprintTile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040B6 RID: 16566
			// (get) Token: 0x0600D05F RID: 53343 RVA: 0x0031FAD0 File Offset: 0x0031DCD0
			// (set) Token: 0x0600D060 RID: 53344 RVA: 0x0006568E File Offset: 0x0006388E
			public unsafe StorageTile storageTile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.StorageTileIntersection.NativeFieldInfoPtr_storageTile);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageTile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.StorageTileIntersection.NativeFieldInfoPtr_storageTile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C97 RID: 35991
			private static readonly IntPtr NativeFieldInfoPtr_footprintTile;

			// Token: 0x04008C98 RID: 35992
			private static readonly IntPtr NativeFieldInfoPtr_storageTile;

			// Token: 0x04008C99 RID: 35993
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

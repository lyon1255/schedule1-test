using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004BE RID: 1214
	public class BuildUpdate_ProceduralGrid : BuildUpdate_Base
	{
		// Token: 0x06006A49 RID: 27209 RVA: 0x001DB1DC File Offset: 0x001D93DC
		// Note: this type is marked as 'beforefieldinit'.
		static BuildUpdate_ProceduralGrid()
		{
			Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildUpdate_ProceduralGrid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr);
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_GhostModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "GhostModel");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_ItemClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "ItemClass");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_ItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "ItemInstance");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_detectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "detectionRange");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_detectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "detectionMask");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_rotation_Smoothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "rotation_Smoothing");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_currentRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "currentRotation");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_validPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "validPosition");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_currentGhostMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "currentGhostMaterial");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_bestIntersection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "bestIntersection");
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676791);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676792);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_CheckRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676793);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676794);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_CheckGridIntersections_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676795);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676796);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_IsMatchValid_Private_Boolean_FootprintTile_ProceduralTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676797);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_Place_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676798);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_GetNearbyProcTile_Private_ProceduralTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676799);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676800);
		}

		// Token: 0x06006A4A RID: 27210 RVA: 0x001DB39C File Offset: 0x001D959C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214293, XrefRangeEnd = 214311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A4B RID: 27211 RVA: 0x001DB3D8 File Offset: 0x001D95D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214311, XrefRangeEnd = 214352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A4C RID: 27212 RVA: 0x001DB414 File Offset: 0x001D9614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214352, XrefRangeEnd = 214365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_CheckRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A4D RID: 27213 RVA: 0x001DB448 File Offset: 0x001D9648
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214396, RefRangeEnd = 214397, XrefRangeStart = 214365, XrefRangeEnd = 214396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A4E RID: 27214 RVA: 0x001DB47C File Offset: 0x001D967C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214397, XrefRangeEnd = 214478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckGridIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_CheckGridIntersections_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A4F RID: 27215 RVA: 0x001DB4B8 File Offset: 0x001D96B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214494, RefRangeEnd = 214495, XrefRangeStart = 214478, XrefRangeEnd = 214494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A50 RID: 27216 RVA: 0x001DB4EC File Offset: 0x001D96EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 214513, RefRangeEnd = 214515, XrefRangeStart = 214495, XrefRangeEnd = 214513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMatchValid(FootprintTile footprintTile, ProceduralTile matchedTile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(footprintTile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matchedTile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_IsMatchValid_Private_Boolean_FootprintTile_ProceduralTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006A51 RID: 27217 RVA: 0x001DB54C File Offset: 0x001D974C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214558, RefRangeEnd = 214559, XrefRangeStart = 214515, XrefRangeEnd = 214558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Place()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_Place_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A52 RID: 27218 RVA: 0x001DB580 File Offset: 0x001D9780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214559, XrefRangeEnd = 214574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralTile GetNearbyProcTile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_GetNearbyProcTile_Private_ProceduralTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProceduralTile>(intPtr3) : null;
		}

		// Token: 0x06006A53 RID: 27219 RVA: 0x001DB5C0 File Offset: 0x001D97C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214574, XrefRangeEnd = 214575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildUpdate_ProceduralGrid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A54 RID: 27220 RVA: 0x0003232E File Offset: 0x0003052E
		public BuildUpdate_ProceduralGrid(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FE3 RID: 8163
		// (get) Token: 0x06006A55 RID: 27221 RVA: 0x001DB5FC File Offset: 0x001D97FC
		// (set) Token: 0x06006A56 RID: 27222 RVA: 0x00032337 File Offset: 0x00030537
		public unsafe GameObject GhostModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_GhostModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_GhostModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FE4 RID: 8164
		// (get) Token: 0x06006A57 RID: 27223 RVA: 0x001DB62C File Offset: 0x001D982C
		// (set) Token: 0x06006A58 RID: 27224 RVA: 0x00032356 File Offset: 0x00030556
		public unsafe ProceduralGridItem ItemClass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_ItemClass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralGridItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_ItemClass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FE5 RID: 8165
		// (get) Token: 0x06006A59 RID: 27225 RVA: 0x001DB65C File Offset: 0x001D985C
		// (set) Token: 0x06006A5A RID: 27226 RVA: 0x00032375 File Offset: 0x00030575
		public unsafe ItemInstance ItemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_ItemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_ItemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FE6 RID: 8166
		// (get) Token: 0x06006A5B RID: 27227 RVA: 0x001DB68C File Offset: 0x001D988C
		// (set) Token: 0x06006A5C RID: 27228 RVA: 0x00032394 File Offset: 0x00030594
		public unsafe float detectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_detectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_detectionRange)) = value;
			}
		}

		// Token: 0x17001FE7 RID: 8167
		// (get) Token: 0x06006A5D RID: 27229 RVA: 0x001DB6B4 File Offset: 0x001D98B4
		// (set) Token: 0x06006A5E RID: 27230 RVA: 0x000323AF File Offset: 0x000305AF
		public unsafe LayerMask detectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_detectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_detectionMask)) = value;
			}
		}

		// Token: 0x17001FE8 RID: 8168
		// (get) Token: 0x06006A5F RID: 27231 RVA: 0x001DB6DC File Offset: 0x001D98DC
		// (set) Token: 0x06006A60 RID: 27232 RVA: 0x000323CA File Offset: 0x000305CA
		public unsafe float rotation_Smoothing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_rotation_Smoothing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_rotation_Smoothing)) = value;
			}
		}

		// Token: 0x17001FE9 RID: 8169
		// (get) Token: 0x06006A61 RID: 27233 RVA: 0x001DB704 File Offset: 0x001D9904
		// (set) Token: 0x06006A62 RID: 27234 RVA: 0x000323E5 File Offset: 0x000305E5
		public unsafe float currentRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_currentRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_currentRotation)) = value;
			}
		}

		// Token: 0x17001FEA RID: 8170
		// (get) Token: 0x06006A63 RID: 27235 RVA: 0x001DB72C File Offset: 0x001D992C
		// (set) Token: 0x06006A64 RID: 27236 RVA: 0x00032400 File Offset: 0x00030600
		public unsafe bool validPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_validPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_validPosition)) = value;
			}
		}

		// Token: 0x17001FEB RID: 8171
		// (get) Token: 0x06006A65 RID: 27237 RVA: 0x001DB754 File Offset: 0x001D9954
		// (set) Token: 0x06006A66 RID: 27238 RVA: 0x0003241B File Offset: 0x0003061B
		public unsafe Material currentGhostMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_currentGhostMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_currentGhostMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FEC RID: 8172
		// (get) Token: 0x06006A67 RID: 27239 RVA: 0x001DB784 File Offset: 0x001D9984
		// (set) Token: 0x06006A68 RID: 27240 RVA: 0x0003243A File Offset: 0x0003063A
		public unsafe BuildUpdate_ProceduralGrid.Intersection bestIntersection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_bestIntersection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildUpdate_ProceduralGrid.Intersection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_bestIntersection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040048C6 RID: 18630
		private static readonly IntPtr NativeFieldInfoPtr_GhostModel;

		// Token: 0x040048C7 RID: 18631
		private static readonly IntPtr NativeFieldInfoPtr_ItemClass;

		// Token: 0x040048C8 RID: 18632
		private static readonly IntPtr NativeFieldInfoPtr_ItemInstance;

		// Token: 0x040048C9 RID: 18633
		private static readonly IntPtr NativeFieldInfoPtr_detectionRange;

		// Token: 0x040048CA RID: 18634
		private static readonly IntPtr NativeFieldInfoPtr_detectionMask;

		// Token: 0x040048CB RID: 18635
		private static readonly IntPtr NativeFieldInfoPtr_rotation_Smoothing;

		// Token: 0x040048CC RID: 18636
		private static readonly IntPtr NativeFieldInfoPtr_currentRotation;

		// Token: 0x040048CD RID: 18637
		private static readonly IntPtr NativeFieldInfoPtr_validPosition;

		// Token: 0x040048CE RID: 18638
		private static readonly IntPtr NativeFieldInfoPtr_currentGhostMaterial;

		// Token: 0x040048CF RID: 18639
		private static readonly IntPtr NativeFieldInfoPtr_bestIntersection;

		// Token: 0x040048D0 RID: 18640
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040048D1 RID: 18641
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040048D2 RID: 18642
		private static readonly IntPtr NativeMethodInfoPtr_CheckRotation_Protected_Void_0;

		// Token: 0x040048D3 RID: 18643
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRotation_Protected_Void_0;

		// Token: 0x040048D4 RID: 18644
		private static readonly IntPtr NativeMethodInfoPtr_CheckGridIntersections_Protected_Virtual_New_Void_0;

		// Token: 0x040048D5 RID: 18645
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0;

		// Token: 0x040048D6 RID: 18646
		private static readonly IntPtr NativeMethodInfoPtr_IsMatchValid_Private_Boolean_FootprintTile_ProceduralTile_0;

		// Token: 0x040048D7 RID: 18647
		private static readonly IntPtr NativeMethodInfoPtr_Place_Protected_Void_0;

		// Token: 0x040048D8 RID: 18648
		private static readonly IntPtr NativeMethodInfoPtr_GetNearbyProcTile_Private_ProceduralTile_0;

		// Token: 0x040048D9 RID: 18649
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A54 RID: 2644
		public class Intersection : Il2CppSystem.Object
		{
			// Token: 0x0600D053 RID: 53331 RVA: 0x0031F8F8 File Offset: 0x0031DAF8
			// Note: this type is marked as 'beforefieldinit'.
			static Intersection()
			{
				Il2CppClassPointerStore<BuildUpdate_ProceduralGrid.Intersection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "Intersection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid.Intersection>.NativeClassPtr);
				BuildUpdate_ProceduralGrid.Intersection.NativeFieldInfoPtr_footprintTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid.Intersection>.NativeClassPtr, "footprintTile");
				BuildUpdate_ProceduralGrid.Intersection.NativeFieldInfoPtr_procTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid.Intersection>.NativeClassPtr, "procTile");
				BuildUpdate_ProceduralGrid.Intersection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid.Intersection>.NativeClassPtr, 100676801);
			}

			// Token: 0x0600D054 RID: 53332 RVA: 0x0031F960 File Offset: 0x0031DB60
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Intersection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid.Intersection>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.Intersection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D055 RID: 53333 RVA: 0x0006561F File Offset: 0x0006381F
			public Intersection(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040B3 RID: 16563
			// (get) Token: 0x0600D056 RID: 53334 RVA: 0x0031F99C File Offset: 0x0031DB9C
			// (set) Token: 0x0600D057 RID: 53335 RVA: 0x00065628 File Offset: 0x00063828
			public unsafe FootprintTile footprintTile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.Intersection.NativeFieldInfoPtr_footprintTile);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.Intersection.NativeFieldInfoPtr_footprintTile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040B4 RID: 16564
			// (get) Token: 0x0600D058 RID: 53336 RVA: 0x0031F9CC File Offset: 0x0031DBCC
			// (set) Token: 0x0600D059 RID: 53337 RVA: 0x00065647 File Offset: 0x00063847
			public unsafe ProceduralTile procTile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.Intersection.NativeFieldInfoPtr_procTile);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralTile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.Intersection.NativeFieldInfoPtr_procTile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C94 RID: 35988
			private static readonly IntPtr NativeFieldInfoPtr_footprintTile;

			// Token: 0x04008C95 RID: 35989
			private static readonly IntPtr NativeFieldInfoPtr_procTile;

			// Token: 0x04008C96 RID: 35990
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

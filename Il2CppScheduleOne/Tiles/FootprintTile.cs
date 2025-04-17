using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Building;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x0200019B RID: 411
	public class FootprintTile : MonoBehaviour
	{
		// Token: 0x060021C5 RID: 8645 RVA: 0x000DA0CC File Offset: 0x000D82CC
		// Note: this type is marked as 'beforefieldinit'.
		static FootprintTile()
		{
			Il2CppClassPointerStore<FootprintTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "FootprintTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr);
			FootprintTile.NativeFieldInfoPtr_tileAppearance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "tileAppearance");
			FootprintTile.NativeFieldInfoPtr_tileDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "tileDetector");
			FootprintTile.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "X");
			FootprintTile.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "Y");
			FootprintTile.NativeFieldInfoPtr_RequiredOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "RequiredOffset");
			FootprintTile.NativeFieldInfoPtr_Corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "Corners");
			FootprintTile.NativeFieldInfoPtr__MatchedStandardTile_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "<MatchedStandardTile>k__BackingField");
			FootprintTile.NativeMethodInfoPtr_get_MatchedStandardTile_Public_get_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, 100667113);
			FootprintTile.NativeMethodInfoPtr_set_MatchedStandardTile_Protected_set_Void_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, 100667114);
			FootprintTile.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, 100667115);
			FootprintTile.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, 100667116);
			FootprintTile.NativeMethodInfoPtr_AreCornerObstaclesBlocked_Public_Boolean_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, 100667117);
			FootprintTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, 100667118);
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x060021C6 RID: 8646 RVA: 0x000DA200 File Offset: 0x000D8400
		// (set) Token: 0x060021C7 RID: 8647 RVA: 0x000DA240 File Offset: 0x000D8440
		public unsafe Tile MatchedStandardTile
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootprintTile.NativeMethodInfoPtr_get_MatchedStandardTile_Public_get_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110710, XrefRangeEnd = 110711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootprintTile.NativeMethodInfoPtr_set_MatchedStandardTile_Protected_set_Void_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x000DA284 File Offset: 0x000D8484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110711, XrefRangeEnd = 110713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootprintTile.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x000DA2C0 File Offset: 0x000D84C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(Tile matchedTile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchedTile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootprintTile.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Tile_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x000DA310 File Offset: 0x000D8510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110785, RefRangeEnd = 110786, XrefRangeStart = 110713, XrefRangeEnd = 110785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreCornerObstaclesBlocked(Tile proposedTile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(proposedTile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootprintTile.NativeMethodInfoPtr_AreCornerObstaclesBlocked_Public_Boolean_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x000DA360 File Offset: 0x000D8560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110786, XrefRangeEnd = 110794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootprintTile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootprintTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x00012D53 File Offset: 0x00010F53
		public FootprintTile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x060021CD RID: 8653 RVA: 0x000DA39C File Offset: 0x000D859C
		// (set) Token: 0x060021CE RID: 8654 RVA: 0x00012D5C File Offset: 0x00010F5C
		public unsafe TileAppearance tileAppearance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_tileAppearance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TileAppearance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_tileAppearance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x060021CF RID: 8655 RVA: 0x000DA3CC File Offset: 0x000D85CC
		// (set) Token: 0x060021D0 RID: 8656 RVA: 0x00012D7B File Offset: 0x00010F7B
		public unsafe TileDetector tileDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_tileDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TileDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_tileDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x000DA3FC File Offset: 0x000D85FC
		// (set) Token: 0x060021D2 RID: 8658 RVA: 0x00012D9A File Offset: 0x00010F9A
		public unsafe int X
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_X);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_X)) = value;
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x060021D3 RID: 8659 RVA: 0x000DA424 File Offset: 0x000D8624
		// (set) Token: 0x060021D4 RID: 8660 RVA: 0x00012DB5 File Offset: 0x00010FB5
		public unsafe int Y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_Y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_Y)) = value;
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x060021D5 RID: 8661 RVA: 0x000DA44C File Offset: 0x000D864C
		// (set) Token: 0x060021D6 RID: 8662 RVA: 0x00012DD0 File Offset: 0x00010FD0
		public unsafe float RequiredOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_RequiredOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_RequiredOffset)) = value;
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x060021D7 RID: 8663 RVA: 0x000DA474 File Offset: 0x000D8674
		// (set) Token: 0x060021D8 RID: 8664 RVA: 0x00012DEB File Offset: 0x00010FEB
		public unsafe List<CornerObstacle> Corners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_Corners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CornerObstacle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_Corners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x060021D9 RID: 8665 RVA: 0x000DA4A4 File Offset: 0x000D86A4
		// (set) Token: 0x060021DA RID: 8666 RVA: 0x00012E0A File Offset: 0x0001100A
		public unsafe Tile _MatchedStandardTile_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr__MatchedStandardTile_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr__MatchedStandardTile_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001679 RID: 5753
		private static readonly IntPtr NativeFieldInfoPtr_tileAppearance;

		// Token: 0x0400167A RID: 5754
		private static readonly IntPtr NativeFieldInfoPtr_tileDetector;

		// Token: 0x0400167B RID: 5755
		private static readonly IntPtr NativeFieldInfoPtr_X;

		// Token: 0x0400167C RID: 5756
		private static readonly IntPtr NativeFieldInfoPtr_Y;

		// Token: 0x0400167D RID: 5757
		private static readonly IntPtr NativeFieldInfoPtr_RequiredOffset;

		// Token: 0x0400167E RID: 5758
		private static readonly IntPtr NativeFieldInfoPtr_Corners;

		// Token: 0x0400167F RID: 5759
		private static readonly IntPtr NativeFieldInfoPtr__MatchedStandardTile_k__BackingField;

		// Token: 0x04001680 RID: 5760
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchedStandardTile_Public_get_Tile_0;

		// Token: 0x04001681 RID: 5761
		private static readonly IntPtr NativeMethodInfoPtr_set_MatchedStandardTile_Protected_set_Void_Tile_0;

		// Token: 0x04001682 RID: 5762
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04001683 RID: 5763
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Tile_0;

		// Token: 0x04001684 RID: 5764
		private static readonly IntPtr NativeMethodInfoPtr_AreCornerObstaclesBlocked_Public_Boolean_Tile_0;

		// Token: 0x04001685 RID: 5765
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200054F RID: 1359
	public class SetTerrainObstacles : MonoBehaviour
	{
		// Token: 0x060077CF RID: 30671 RVA: 0x002072A0 File Offset: 0x002054A0
		// Note: this type is marked as 'beforefieldinit'.
		static SetTerrainObstacles()
		{
			Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "SetTerrainObstacles");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr);
			SetTerrainObstacles.NativeFieldInfoPtr_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "Bounds");
			SetTerrainObstacles.NativeFieldInfoPtr_Obstacle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "Obstacle");
			SetTerrainObstacles.NativeFieldInfoPtr_terrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "terrain");
			SetTerrainObstacles.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "width");
			SetTerrainObstacles.NativeFieldInfoPtr_lenght = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "lenght");
			SetTerrainObstacles.NativeFieldInfoPtr_hight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "hight");
			SetTerrainObstacles.NativeFieldInfoPtr_isError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "isError");
			SetTerrainObstacles.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, 100678371);
			SetTerrainObstacles.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, 100678372);
		}

		// Token: 0x060077D0 RID: 30672 RVA: 0x00207384 File Offset: 0x00205584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231924, XrefRangeEnd = 232074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTerrainObstacles.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077D1 RID: 30673 RVA: 0x002073B8 File Offset: 0x002055B8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetTerrainObstacles() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTerrainObstacles.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077D2 RID: 30674 RVA: 0x00038BD0 File Offset: 0x00036DD0
		public SetTerrainObstacles(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002432 RID: 9266
		// (get) Token: 0x060077D3 RID: 30675 RVA: 0x002073F4 File Offset: 0x002055F4
		// (set) Token: 0x060077D4 RID: 30676 RVA: 0x00038BD9 File Offset: 0x00036DD9
		public unsafe BoxCollider Bounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_Bounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_Bounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002433 RID: 9267
		// (get) Token: 0x060077D5 RID: 30677 RVA: 0x00207424 File Offset: 0x00205624
		// (set) Token: 0x060077D6 RID: 30678 RVA: 0x00038BF8 File Offset: 0x00036DF8
		public unsafe Il2CppStructArray<TreeInstance> Obstacle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_Obstacle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TreeInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_Obstacle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002434 RID: 9268
		// (get) Token: 0x060077D7 RID: 30679 RVA: 0x00207454 File Offset: 0x00205654
		// (set) Token: 0x060077D8 RID: 30680 RVA: 0x00038C17 File Offset: 0x00036E17
		public unsafe Terrain terrain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_terrain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Terrain>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_terrain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002435 RID: 9269
		// (get) Token: 0x060077D9 RID: 30681 RVA: 0x00207484 File Offset: 0x00205684
		// (set) Token: 0x060077DA RID: 30682 RVA: 0x00038C36 File Offset: 0x00036E36
		public unsafe float width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_width)) = value;
			}
		}

		// Token: 0x17002436 RID: 9270
		// (get) Token: 0x060077DB RID: 30683 RVA: 0x002074AC File Offset: 0x002056AC
		// (set) Token: 0x060077DC RID: 30684 RVA: 0x00038C51 File Offset: 0x00036E51
		public unsafe float lenght
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_lenght);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_lenght)) = value;
			}
		}

		// Token: 0x17002437 RID: 9271
		// (get) Token: 0x060077DD RID: 30685 RVA: 0x002074D4 File Offset: 0x002056D4
		// (set) Token: 0x060077DE RID: 30686 RVA: 0x00038C6C File Offset: 0x00036E6C
		public unsafe float hight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_hight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_hight)) = value;
			}
		}

		// Token: 0x17002438 RID: 9272
		// (get) Token: 0x060077DF RID: 30687 RVA: 0x002074FC File Offset: 0x002056FC
		// (set) Token: 0x060077E0 RID: 30688 RVA: 0x00038C87 File Offset: 0x00036E87
		public unsafe bool isError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_isError);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_isError)) = value;
			}
		}

		// Token: 0x040051B8 RID: 20920
		private static readonly IntPtr NativeFieldInfoPtr_Bounds;

		// Token: 0x040051B9 RID: 20921
		private static readonly IntPtr NativeFieldInfoPtr_Obstacle;

		// Token: 0x040051BA RID: 20922
		private static readonly IntPtr NativeFieldInfoPtr_terrain;

		// Token: 0x040051BB RID: 20923
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x040051BC RID: 20924
		private static readonly IntPtr NativeFieldInfoPtr_lenght;

		// Token: 0x040051BD RID: 20925
		private static readonly IntPtr NativeFieldInfoPtr_hight;

		// Token: 0x040051BE RID: 20926
		private static readonly IntPtr NativeFieldInfoPtr_isError;

		// Token: 0x040051BF RID: 20927
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040051C0 RID: 20928
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

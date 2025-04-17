﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200025E RID: 606
	[Serializable]
	public class FootprintMatchData : Il2CppSystem.Object
	{
		// Token: 0x06002EEA RID: 12010 RVA: 0x00106184 File Offset: 0x00104384
		// Note: this type is marked as 'beforefieldinit'.
		static FootprintMatchData()
		{
			Il2CppClassPointerStore<FootprintMatchData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "FootprintMatchData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootprintMatchData>.NativeClassPtr);
			FootprintMatchData.NativeFieldInfoPtr_TileOwnerGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintMatchData>.NativeClassPtr, "TileOwnerGUID");
			FootprintMatchData.NativeFieldInfoPtr_TileIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintMatchData>.NativeClassPtr, "TileIndex");
			FootprintMatchData.NativeFieldInfoPtr_FootprintCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintMatchData>.NativeClassPtr, "FootprintCoordinate");
			FootprintMatchData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintMatchData>.NativeClassPtr, 100668731);
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x00106204 File Offset: 0x00104404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130432, RefRangeEnd = 130433, XrefRangeStart = 130430, XrefRangeEnd = 130432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootprintMatchData(string tileOwnerGUID, int tileIndex, Vector2 footprintCoordinate) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootprintMatchData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(tileOwnerGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tileIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref footprintCoordinate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootprintMatchData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EEC RID: 12012 RVA: 0x00018CB0 File Offset: 0x00016EB0
		public FootprintMatchData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06002EED RID: 12013 RVA: 0x0010626C File Offset: 0x0010446C
		// (set) Token: 0x06002EEE RID: 12014 RVA: 0x00018CB9 File Offset: 0x00016EB9
		public unsafe string TileOwnerGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintMatchData.NativeFieldInfoPtr_TileOwnerGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintMatchData.NativeFieldInfoPtr_TileOwnerGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x06002EEF RID: 12015 RVA: 0x00106294 File Offset: 0x00104494
		// (set) Token: 0x06002EF0 RID: 12016 RVA: 0x00018CD8 File Offset: 0x00016ED8
		public unsafe int TileIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintMatchData.NativeFieldInfoPtr_TileIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintMatchData.NativeFieldInfoPtr_TileIndex)) = value;
			}
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06002EF1 RID: 12017 RVA: 0x001062BC File Offset: 0x001044BC
		// (set) Token: 0x06002EF2 RID: 12018 RVA: 0x00018CF3 File Offset: 0x00016EF3
		public unsafe Vector2 FootprintCoordinate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintMatchData.NativeFieldInfoPtr_FootprintCoordinate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintMatchData.NativeFieldInfoPtr_FootprintCoordinate)) = value;
			}
		}

		// Token: 0x04001F04 RID: 7940
		private static readonly IntPtr NativeFieldInfoPtr_TileOwnerGUID;

		// Token: 0x04001F05 RID: 7941
		private static readonly IntPtr NativeFieldInfoPtr_TileIndex;

		// Token: 0x04001F06 RID: 7942
		private static readonly IntPtr NativeFieldInfoPtr_FootprintCoordinate;

		// Token: 0x04001F07 RID: 7943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Vector2_0;
	}
}

﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x0200019D RID: 413
	public class IndoorTile : Tile
	{
		// Token: 0x060021FC RID: 8700 RVA: 0x00012F11 File Offset: 0x00011111
		// Note: this type is marked as 'beforefieldinit'.
		static IndoorTile()
		{
			Il2CppClassPointerStore<IndoorTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "IndoorTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndoorTile>.NativeClassPtr);
			IndoorTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndoorTile>.NativeClassPtr, 100667137);
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x000DAC40 File Offset: 0x000D8E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111041, XrefRangeEnd = 111066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndoorTile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndoorTile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndoorTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x00012F4A File Offset: 0x0001114A
		public IndoorTile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400169D RID: 5789
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

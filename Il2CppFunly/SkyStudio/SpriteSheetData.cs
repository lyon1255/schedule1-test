using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000124 RID: 292
	public class SpriteSheetData : Object
	{
		// Token: 0x060018CC RID: 6348 RVA: 0x000BDE60 File Offset: 0x000BC060
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteSheetData()
		{
			Il2CppClassPointerStore<SpriteSheetData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "SpriteSheetData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteSheetData>.NativeClassPtr);
			SpriteSheetData.NativeFieldInfoPtr_columns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSheetData>.NativeClassPtr, "columns");
			SpriteSheetData.NativeFieldInfoPtr_rows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSheetData>.NativeClassPtr, "rows");
			SpriteSheetData.NativeFieldInfoPtr_frameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSheetData>.NativeClassPtr, "frameCount");
			SpriteSheetData.NativeFieldInfoPtr_frameRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSheetData>.NativeClassPtr, "frameRate");
			SpriteSheetData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSheetData>.NativeClassPtr, 100665939);
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x000BDEF4 File Offset: 0x000BC0F4
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpriteSheetData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteSheetData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteSheetData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x0000E2F6 File Offset: 0x0000C4F6
		public SpriteSheetData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x060018CF RID: 6351 RVA: 0x000BDF30 File Offset: 0x000BC130
		// (set) Token: 0x060018D0 RID: 6352 RVA: 0x0000E2FF File Offset: 0x0000C4FF
		public unsafe int columns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteSheetData.NativeFieldInfoPtr_columns);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteSheetData.NativeFieldInfoPtr_columns)) = value;
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x060018D1 RID: 6353 RVA: 0x000BDF58 File Offset: 0x000BC158
		// (set) Token: 0x060018D2 RID: 6354 RVA: 0x0000E31A File Offset: 0x0000C51A
		public unsafe int rows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteSheetData.NativeFieldInfoPtr_rows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteSheetData.NativeFieldInfoPtr_rows)) = value;
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x060018D3 RID: 6355 RVA: 0x000BDF80 File Offset: 0x000BC180
		// (set) Token: 0x060018D4 RID: 6356 RVA: 0x0000E335 File Offset: 0x0000C535
		public unsafe int frameCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteSheetData.NativeFieldInfoPtr_frameCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteSheetData.NativeFieldInfoPtr_frameCount)) = value;
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x060018D5 RID: 6357 RVA: 0x000BDFA8 File Offset: 0x000BC1A8
		// (set) Token: 0x060018D6 RID: 6358 RVA: 0x0000E350 File Offset: 0x0000C550
		public unsafe int frameRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteSheetData.NativeFieldInfoPtr_frameRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteSheetData.NativeFieldInfoPtr_frameRate)) = value;
			}
		}

		// Token: 0x0400104A RID: 4170
		private static readonly IntPtr NativeFieldInfoPtr_columns;

		// Token: 0x0400104B RID: 4171
		private static readonly IntPtr NativeFieldInfoPtr_rows;

		// Token: 0x0400104C RID: 4172
		private static readonly IntPtr NativeFieldInfoPtr_frameCount;

		// Token: 0x0400104D RID: 4173
		private static readonly IntPtr NativeFieldInfoPtr_frameRate;

		// Token: 0x0400104E RID: 4174
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

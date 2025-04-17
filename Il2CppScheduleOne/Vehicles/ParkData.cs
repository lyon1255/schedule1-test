using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004E3 RID: 1251
	[Serializable]
	public class ParkData : Object
	{
		// Token: 0x06006E95 RID: 28309 RVA: 0x001E91C0 File Offset: 0x001E73C0
		// Note: this type is marked as 'beforefieldinit'.
		static ParkData()
		{
			Il2CppClassPointerStore<ParkData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "ParkData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParkData>.NativeClassPtr);
			ParkData.NativeFieldInfoPtr_lotGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkData>.NativeClassPtr, "lotGUID");
			ParkData.NativeFieldInfoPtr_spotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkData>.NativeClassPtr, "spotIndex");
			ParkData.NativeFieldInfoPtr_alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkData>.NativeClassPtr, "alignment");
			ParkData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkData>.NativeClassPtr, 100677287);
		}

		// Token: 0x06006E96 RID: 28310 RVA: 0x001E9240 File Offset: 0x001E7440
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParkData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParkData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E97 RID: 28311 RVA: 0x0003450E File Offset: 0x0003270E
		public ParkData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002154 RID: 8532
		// (get) Token: 0x06006E98 RID: 28312 RVA: 0x001E927C File Offset: 0x001E747C
		// (set) Token: 0x06006E99 RID: 28313 RVA: 0x00034517 File Offset: 0x00032717
		public unsafe Guid lotGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkData.NativeFieldInfoPtr_lotGUID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkData.NativeFieldInfoPtr_lotGUID)) = value;
			}
		}

		// Token: 0x17002155 RID: 8533
		// (get) Token: 0x06006E9A RID: 28314 RVA: 0x001E92A4 File Offset: 0x001E74A4
		// (set) Token: 0x06006E9B RID: 28315 RVA: 0x00034532 File Offset: 0x00032732
		public unsafe int spotIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkData.NativeFieldInfoPtr_spotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkData.NativeFieldInfoPtr_spotIndex)) = value;
			}
		}

		// Token: 0x17002156 RID: 8534
		// (get) Token: 0x06006E9C RID: 28316 RVA: 0x001E92CC File Offset: 0x001E74CC
		// (set) Token: 0x06006E9D RID: 28317 RVA: 0x0003454D File Offset: 0x0003274D
		public unsafe EParkingAlignment alignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkData.NativeFieldInfoPtr_alignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkData.NativeFieldInfoPtr_alignment)) = value;
			}
		}

		// Token: 0x04004BAC RID: 19372
		private static readonly IntPtr NativeFieldInfoPtr_lotGUID;

		// Token: 0x04004BAD RID: 19373
		private static readonly IntPtr NativeFieldInfoPtr_spotIndex;

		// Token: 0x04004BAE RID: 19374
		private static readonly IntPtr NativeFieldInfoPtr_alignment;

		// Token: 0x04004BAF RID: 19375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000283 RID: 643
	[Serializable]
	public class QualityFieldData : Object
	{
		// Token: 0x06002FE0 RID: 12256 RVA: 0x00108C34 File Offset: 0x00106E34
		// Note: this type is marked as 'beforefieldinit'.
		static QualityFieldData()
		{
			Il2CppClassPointerStore<QualityFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "QualityFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityFieldData>.NativeClassPtr);
			QualityFieldData.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityFieldData>.NativeClassPtr, "Value");
			QualityFieldData.NativeMethodInfoPtr__ctor_Public_Void_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldData>.NativeClassPtr, 100668791);
		}

		// Token: 0x06002FE1 RID: 12257 RVA: 0x00108C8C File Offset: 0x00106E8C
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityFieldData(EQuality value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityFieldData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldData.NativeMethodInfoPtr__ctor_Public_Void_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FE2 RID: 12258 RVA: 0x0001961B File Offset: 0x0001781B
		public QualityFieldData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x06002FE3 RID: 12259 RVA: 0x00108CD4 File Offset: 0x00106ED4
		// (set) Token: 0x06002FE4 RID: 12260 RVA: 0x00019624 File Offset: 0x00017824
		public unsafe EQuality Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldData.NativeFieldInfoPtr_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldData.NativeFieldInfoPtr_Value)) = value;
			}
		}

		// Token: 0x04001F72 RID: 8050
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001F73 RID: 8051
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EQuality_0;
	}
}

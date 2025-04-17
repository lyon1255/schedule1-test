using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200026F RID: 623
	[Serializable]
	public class LaunderOperationData : SaveData
	{
		// Token: 0x06002F59 RID: 12121 RVA: 0x001075F0 File Offset: 0x001057F0
		// Note: this type is marked as 'beforefieldinit'.
		static LaunderOperationData()
		{
			Il2CppClassPointerStore<LaunderOperationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "LaunderOperationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LaunderOperationData>.NativeClassPtr);
			LaunderOperationData.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderOperationData>.NativeClassPtr, "Amount");
			LaunderOperationData.NativeFieldInfoPtr_MinutesSinceStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderOperationData>.NativeClassPtr, "MinutesSinceStarted");
			LaunderOperationData.NativeMethodInfoPtr__ctor_Public_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderOperationData>.NativeClassPtr, 100668770);
		}

		// Token: 0x06002F5A RID: 12122 RVA: 0x0010765C File Offset: 0x0010585C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130612, RefRangeEnd = 130613, XrefRangeStart = 130611, XrefRangeEnd = 130612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LaunderOperationData(float amount, int minutesSinceStarted) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LaunderOperationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderOperationData.NativeMethodInfoPtr__ctor_Public_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F5B RID: 12123 RVA: 0x00019100 File Offset: 0x00017300
		public LaunderOperationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06002F5C RID: 12124 RVA: 0x001076B4 File Offset: 0x001058B4
		// (set) Token: 0x06002F5D RID: 12125 RVA: 0x00019109 File Offset: 0x00017309
		public unsafe float Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderOperationData.NativeFieldInfoPtr_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderOperationData.NativeFieldInfoPtr_Amount)) = value;
			}
		}

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06002F5E RID: 12126 RVA: 0x001076DC File Offset: 0x001058DC
		// (set) Token: 0x06002F5F RID: 12127 RVA: 0x00019124 File Offset: 0x00017324
		public unsafe int MinutesSinceStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderOperationData.NativeFieldInfoPtr_MinutesSinceStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderOperationData.NativeFieldInfoPtr_MinutesSinceStarted)) = value;
			}
		}

		// Token: 0x04001F38 RID: 7992
		private static readonly IntPtr NativeFieldInfoPtr_Amount;

		// Token: 0x04001F39 RID: 7993
		private static readonly IntPtr NativeFieldInfoPtr_MinutesSinceStarted;

		// Token: 0x04001F3A RID: 7994
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Int32_0;
	}
}

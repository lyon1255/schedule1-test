using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200027D RID: 637
	[Serializable]
	public class NumberFieldData : Object
	{
		// Token: 0x06002FB6 RID: 12214 RVA: 0x00108548 File Offset: 0x00106748
		// Note: this type is marked as 'beforefieldinit'.
		static NumberFieldData()
		{
			Il2CppClassPointerStore<NumberFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "NumberFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberFieldData>.NativeClassPtr);
			NumberFieldData.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldData>.NativeClassPtr, "Value");
			NumberFieldData.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldData>.NativeClassPtr, 100668785);
		}

		// Token: 0x06002FB7 RID: 12215 RVA: 0x001085A0 File Offset: 0x001067A0
		[CallerCount(143)]
		[CachedScanResults(RefRangeStart = 130639, RefRangeEnd = 130782, XrefRangeStart = 130638, XrefRangeEnd = 130639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberFieldData(float value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberFieldData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldData.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FB8 RID: 12216 RVA: 0x00019475 File Offset: 0x00017675
		public NumberFieldData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x06002FB9 RID: 12217 RVA: 0x001085E8 File Offset: 0x001067E8
		// (set) Token: 0x06002FBA RID: 12218 RVA: 0x0001947E File Offset: 0x0001767E
		public unsafe float Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldData.NativeFieldInfoPtr_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldData.NativeFieldInfoPtr_Value)) = value;
			}
		}

		// Token: 0x04001F60 RID: 8032
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001F61 RID: 8033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
	}
}

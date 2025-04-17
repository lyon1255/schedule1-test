using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000273 RID: 627
	[Serializable]
	public class BrickPressConfigurationData : SaveData
	{
		// Token: 0x06002F7A RID: 12154 RVA: 0x00107B58 File Offset: 0x00105D58
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressConfigurationData()
		{
			Il2CppClassPointerStore<BrickPressConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "BrickPressConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressConfigurationData>.NativeClassPtr);
			BrickPressConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressConfigurationData>.NativeClassPtr, "Destination");
			BrickPressConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressConfigurationData>.NativeClassPtr, 100668775);
		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x00107BB0 File Offset: 0x00105DB0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 130391, RefRangeEnd = 130397, XrefRangeStart = 130391, XrefRangeEnd = 130397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressConfigurationData(ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x0001924A File Offset: 0x0001744A
		public BrickPressConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06002F7D RID: 12157 RVA: 0x00107BFC File Offset: 0x00105DFC
		// (set) Token: 0x06002F7E RID: 12158 RVA: 0x00019253 File Offset: 0x00017453
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F47 RID: 8007
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04001F48 RID: 8008
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0;
	}
}

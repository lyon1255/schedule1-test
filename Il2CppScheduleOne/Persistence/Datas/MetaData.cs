using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000286 RID: 646
	[Serializable]
	public class MetaData : SaveData
	{
		// Token: 0x06002FEF RID: 12271 RVA: 0x00108E9C File Offset: 0x0010709C
		// Note: this type is marked as 'beforefieldinit'.
		static MetaData()
		{
			Il2CppClassPointerStore<MetaData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MetaData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetaData>.NativeClassPtr);
			MetaData.NativeFieldInfoPtr_CreationDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaData>.NativeClassPtr, "CreationDate");
			MetaData.NativeFieldInfoPtr_LastPlayedDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaData>.NativeClassPtr, "LastPlayedDate");
			MetaData.NativeFieldInfoPtr_CreationVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaData>.NativeClassPtr, "CreationVersion");
			MetaData.NativeFieldInfoPtr_LastSaveVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaData>.NativeClassPtr, "LastSaveVersion");
			MetaData.NativeFieldInfoPtr_PlayTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaData>.NativeClassPtr, "PlayTutorial");
			MetaData.NativeMethodInfoPtr__ctor_Public_Void_DateTimeData_DateTimeData_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaData>.NativeClassPtr, 100668794);
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x00108F44 File Offset: 0x00107144
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130794, RefRangeEnd = 130798, XrefRangeStart = 130789, XrefRangeEnd = 130794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MetaData(DateTimeData creationDate, DateTimeData lastPlayedDate, string creationVersion, string lastSaveVersion, bool playTutorial) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetaData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(creationDate);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lastPlayedDate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(creationVersion);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastSaveVersion);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playTutorial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaData.NativeMethodInfoPtr__ctor_Public_Void_DateTimeData_DateTimeData_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FF1 RID: 12273 RVA: 0x0001968F File Offset: 0x0001788F
		public MetaData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x06002FF2 RID: 12274 RVA: 0x00108FD4 File Offset: 0x001071D4
		// (set) Token: 0x06002FF3 RID: 12275 RVA: 0x00019698 File Offset: 0x00017898
		public unsafe DateTimeData CreationDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_CreationDate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_CreationDate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x06002FF4 RID: 12276 RVA: 0x00109004 File Offset: 0x00107204
		// (set) Token: 0x06002FF5 RID: 12277 RVA: 0x000196B7 File Offset: 0x000178B7
		public unsafe DateTimeData LastPlayedDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_LastPlayedDate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_LastPlayedDate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x06002FF6 RID: 12278 RVA: 0x00109034 File Offset: 0x00107234
		// (set) Token: 0x06002FF7 RID: 12279 RVA: 0x000196D6 File Offset: 0x000178D6
		public unsafe string CreationVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_CreationVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_CreationVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x06002FF8 RID: 12280 RVA: 0x0010905C File Offset: 0x0010725C
		// (set) Token: 0x06002FF9 RID: 12281 RVA: 0x000196F5 File Offset: 0x000178F5
		public unsafe string LastSaveVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_LastSaveVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_LastSaveVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06002FFA RID: 12282 RVA: 0x00109084 File Offset: 0x00107284
		// (set) Token: 0x06002FFB RID: 12283 RVA: 0x00019714 File Offset: 0x00017914
		public unsafe bool PlayTutorial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_PlayTutorial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_PlayTutorial)) = value;
			}
		}

		// Token: 0x04001F78 RID: 8056
		private static readonly IntPtr NativeFieldInfoPtr_CreationDate;

		// Token: 0x04001F79 RID: 8057
		private static readonly IntPtr NativeFieldInfoPtr_LastPlayedDate;

		// Token: 0x04001F7A RID: 8058
		private static readonly IntPtr NativeFieldInfoPtr_CreationVersion;

		// Token: 0x04001F7B RID: 8059
		private static readonly IntPtr NativeFieldInfoPtr_LastSaveVersion;

		// Token: 0x04001F7C RID: 8060
		private static readonly IntPtr NativeFieldInfoPtr_PlayTutorial;

		// Token: 0x04001F7D RID: 8061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTimeData_DateTimeData_String_String_Boolean_0;
	}
}

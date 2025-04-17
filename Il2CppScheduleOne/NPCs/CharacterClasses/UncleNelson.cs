using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000338 RID: 824
	public class UncleNelson : NPC
	{
		// Token: 0x06003CC3 RID: 15555 RVA: 0x00136060 File Offset: 0x00134260
		// Note: this type is marked as 'beforefieldinit'.
		static UncleNelson()
		{
			Il2CppClassPointerStore<UncleNelson>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "UncleNelson");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr);
			UncleNelson.NativeFieldInfoPtr_InitialMessage_Demo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, "InitialMessage_Demo");
			UncleNelson.NativeFieldInfoPtr_InitialMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, "InitialMessage");
			UncleNelson.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.UncleNelsonAssembly-CSharp.dll_Excuted");
			UncleNelson.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.UncleNelsonAssembly-CSharp.dll_Excuted");
			UncleNelson.NativeMethodInfoPtr_SendInitialMessage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, 100670383);
			UncleNelson.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, 100670384);
			UncleNelson.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, 100670385);
			UncleNelson.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, 100670386);
			UncleNelson.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, 100670387);
			UncleNelson.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, 100670388);
		}

		// Token: 0x06003CC4 RID: 15556 RVA: 0x00136158 File Offset: 0x00134358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143068, XrefRangeEnd = 143089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendInitialMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UncleNelson.NativeMethodInfoPtr_SendInitialMessage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CC5 RID: 15557 RVA: 0x0013618C File Offset: 0x0013438C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143089, XrefRangeEnd = 143098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UncleNelson() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UncleNelson.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CC6 RID: 15558 RVA: 0x001361C8 File Offset: 0x001343C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UncleNelson.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CC7 RID: 15559 RVA: 0x00136204 File Offset: 0x00134404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UncleNelson.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CC8 RID: 15560 RVA: 0x00136240 File Offset: 0x00134440
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UncleNelson.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CC9 RID: 15561 RVA: 0x0013627C File Offset: 0x0013447C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 141969, RefRangeEnd = 141972, XrefRangeStart = 141969, XrefRangeEnd = 141972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UncleNelson.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CCA RID: 15562 RVA: 0x0001EC58 File Offset: 0x0001CE58
		public UncleNelson(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x06003CCB RID: 15563 RVA: 0x001362B8 File Offset: 0x001344B8
		// (set) Token: 0x06003CCC RID: 15564 RVA: 0x0001EC61 File Offset: 0x0001CE61
		public unsafe string InitialMessage_Demo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UncleNelson.NativeFieldInfoPtr_InitialMessage_Demo);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UncleNelson.NativeFieldInfoPtr_InitialMessage_Demo), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x06003CCD RID: 15565 RVA: 0x001362E0 File Offset: 0x001344E0
		// (set) Token: 0x06003CCE RID: 15566 RVA: 0x0001EC80 File Offset: 0x0001CE80
		public unsafe string InitialMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UncleNelson.NativeFieldInfoPtr_InitialMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UncleNelson.NativeFieldInfoPtr_InitialMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x06003CCF RID: 15567 RVA: 0x00136308 File Offset: 0x00134508
		// (set) Token: 0x06003CD0 RID: 15568 RVA: 0x0001EC9F File Offset: 0x0001CE9F
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UncleNelson.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UncleNelson.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x06003CD1 RID: 15569 RVA: 0x00136330 File Offset: 0x00134530
		// (set) Token: 0x06003CD2 RID: 15570 RVA: 0x0001ECBA File Offset: 0x0001CEBA
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UncleNelson.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UncleNelson.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002815 RID: 10261
		private static readonly IntPtr NativeFieldInfoPtr_InitialMessage_Demo;

		// Token: 0x04002816 RID: 10262
		private static readonly IntPtr NativeFieldInfoPtr_InitialMessage;

		// Token: 0x04002817 RID: 10263
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002818 RID: 10264
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002819 RID: 10265
		private static readonly IntPtr NativeMethodInfoPtr_SendInitialMessage_Public_Void_0;

		// Token: 0x0400281A RID: 10266
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400281B RID: 10267
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400281C RID: 10268
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400281D RID: 10269
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400281E RID: 10270
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}

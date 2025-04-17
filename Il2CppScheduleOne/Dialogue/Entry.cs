using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000438 RID: 1080
	[Serializable]
	public sealed class Entry : ValueType
	{
		// Token: 0x06005EA7 RID: 24231 RVA: 0x001B3930 File Offset: 0x001B1B30
		// Note: this type is marked as 'beforefieldinit'.
		static Entry()
		{
			Il2CppClassPointerStore<Entry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "Entry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entry>.NativeClassPtr);
			Entry.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entry>.NativeClassPtr, "Key");
			Entry.NativeFieldInfoPtr_Chains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entry>.NativeClassPtr, "Chains");
			Entry.NativeMethodInfoPtr_GetRandomChain_Public_DialogueChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entry>.NativeClassPtr, 100675362);
			Entry.NativeMethodInfoPtr_GetRandomLine_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entry>.NativeClassPtr, 100675363);
		}

		// Token: 0x06005EA8 RID: 24232 RVA: 0x001B39B0 File Offset: 0x001B1BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197444, XrefRangeEnd = 197445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChain GetRandomChain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entry.NativeMethodInfoPtr_GetRandomChain_Public_DialogueChain_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueChain>(intPtr3) : null;
		}

		// Token: 0x06005EA9 RID: 24233 RVA: 0x001B39F4 File Offset: 0x001B1BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197445, XrefRangeEnd = 197446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetRandomLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entry.NativeMethodInfoPtr_GetRandomLine_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005EAA RID: 24234 RVA: 0x0002C9E7 File Offset: 0x0002ABE7
		public Entry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06005EAB RID: 24235 RVA: 0x0002C9F0 File Offset: 0x0002ABF0
		public Entry() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entry>.NativeClassPtr))
		{
		}

		// Token: 0x17001C71 RID: 7281
		// (get) Token: 0x06005EAC RID: 24236 RVA: 0x001B3A30 File Offset: 0x001B1C30
		// (set) Token: 0x06005EAD RID: 24237 RVA: 0x0002CA02 File Offset: 0x0002AC02
		public unsafe string Key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entry.NativeFieldInfoPtr_Key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entry.NativeFieldInfoPtr_Key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C72 RID: 7282
		// (get) Token: 0x06005EAE RID: 24238 RVA: 0x001B3A58 File Offset: 0x001B1C58
		// (set) Token: 0x06005EAF RID: 24239 RVA: 0x0002CA21 File Offset: 0x0002AC21
		public unsafe Il2CppReferenceArray<DialogueChain> Chains
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entry.NativeFieldInfoPtr_Chains);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogueChain>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entry.NativeFieldInfoPtr_Chains), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040040BA RID: 16570
		private static readonly IntPtr NativeFieldInfoPtr_Key;

		// Token: 0x040040BB RID: 16571
		private static readonly IntPtr NativeFieldInfoPtr_Chains;

		// Token: 0x040040BC RID: 16572
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomChain_Public_DialogueChain_0;

		// Token: 0x040040BD RID: 16573
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomLine_Public_String_0;
	}
}

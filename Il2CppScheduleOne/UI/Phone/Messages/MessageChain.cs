using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020006B0 RID: 1712
	[Serializable]
	public class MessageChain : Object
	{
		// Token: 0x06009A09 RID: 39433 RVA: 0x00272F78 File Offset: 0x00271178
		// Note: this type is marked as 'beforefieldinit'.
		static MessageChain()
		{
			Il2CppClassPointerStore<MessageChain>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "MessageChain");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageChain>.NativeClassPtr);
			MessageChain.NativeFieldInfoPtr_Messages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageChain>.NativeClassPtr, "Messages");
			MessageChain.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageChain>.NativeClassPtr, "id");
			MessageChain.NativeMethodInfoPtr_Combine_Public_Static_MessageChain_MessageChain_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageChain>.NativeClassPtr, 100682264);
			MessageChain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageChain>.NativeClassPtr, 100682265);
		}

		// Token: 0x06009A0A RID: 39434 RVA: 0x00272FF8 File Offset: 0x002711F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274079, XrefRangeEnd = 274095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MessageChain Combine(MessageChain a, MessageChain b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageChain.NativeMethodInfoPtr_Combine_Public_Static_MessageChain_MessageChain_MessageChain_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr3) : null;
		}

		// Token: 0x06009A0B RID: 39435 RVA: 0x00273050 File Offset: 0x00271250
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 274103, RefRangeEnd = 274112, XrefRangeStart = 274095, XrefRangeEnd = 274103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageChain() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageChain>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageChain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A0C RID: 39436 RVA: 0x0004B380 File Offset: 0x00049580
		public MessageChain(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F61 RID: 12129
		// (get) Token: 0x06009A0D RID: 39437 RVA: 0x0027308C File Offset: 0x0027128C
		// (set) Token: 0x06009A0E RID: 39438 RVA: 0x0004B389 File Offset: 0x00049589
		public unsafe List<string> Messages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageChain.NativeFieldInfoPtr_Messages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageChain.NativeFieldInfoPtr_Messages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F62 RID: 12130
		// (get) Token: 0x06009A0F RID: 39439 RVA: 0x002730BC File Offset: 0x002712BC
		// (set) Token: 0x06009A10 RID: 39440 RVA: 0x0004B3A8 File Offset: 0x000495A8
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageChain.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageChain.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x040067A7 RID: 26535
		private static readonly IntPtr NativeFieldInfoPtr_Messages;

		// Token: 0x040067A8 RID: 26536
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x040067A9 RID: 26537
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_MessageChain_MessageChain_MessageChain_0;

		// Token: 0x040067AA RID: 26538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.Interaction;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200001A RID: 26
	public class TestNPC : MonoBehaviour
	{
		// Token: 0x060001A0 RID: 416 RVA: 0x00075B38 File Offset: 0x00073D38
		// Note: this type is marked as 'beforefieldinit'.
		static TestNPC()
		{
			Il2CppClassPointerStore<TestNPC>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TestNPC");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TestNPC>.NativeClassPtr);
			TestNPC.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestNPC>.NativeClassPtr, "intObj");
			TestNPC.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestNPC>.NativeClassPtr, "handler");
			TestNPC.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestNPC>.NativeClassPtr, 100663448);
			TestNPC.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestNPC>.NativeClassPtr, 100663449);
			TestNPC.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestNPC>.NativeClassPtr, 100663450);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00075BCC File Offset: 0x00073DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72160, XrefRangeEnd = 72166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestNPC.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00075C00 File Offset: 0x00073E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72166, XrefRangeEnd = 72171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestNPC.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00075C34 File Offset: 0x00073E34
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TestNPC() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TestNPC>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestNPC.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002E41 File Offset: 0x00001041
		public TestNPC(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00075C70 File Offset: 0x00073E70
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00002E4A File Offset: 0x0000104A
		public unsafe InteractableObject intObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestNPC.NativeFieldInfoPtr_intObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestNPC.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00075CA0 File Offset: 0x00073EA0
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00002E69 File Offset: 0x00001069
		public unsafe DialogueHandler handler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestNPC.NativeFieldInfoPtr_handler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TestNPC.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_handler;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

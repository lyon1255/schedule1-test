using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne
{
	// Token: 0x0200016B RID: 363
	public static class XPAmounts : Object
	{
		// Token: 0x06001D62 RID: 7522 RVA: 0x000CBE34 File Offset: 0x000CA034
		// Note: this type is marked as 'beforefieldinit'.
		static XPAmounts()
		{
			Il2CppClassPointerStore<XPAmounts>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "XPAmounts");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPAmounts>.NativeClassPtr);
			XPAmounts.NativeFieldInfoPtr_PLAYER_COMPLETED_DEAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPAmounts>.NativeClassPtr, "PLAYER_COMPLETED_DEAL");
			XPAmounts.NativeFieldInfoPtr_DEALER_COMPLETED_DEAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPAmounts>.NativeClassPtr, "DEALER_COMPLETED_DEAL");
			XPAmounts.NativeFieldInfoPtr_SUCCESSFUL_SAMPLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPAmounts>.NativeClassPtr, "SUCCESSFUL_SAMPLE");
			XPAmounts.NativeFieldInfoPtr_HARVESTED_PLANT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPAmounts>.NativeClassPtr, "HARVESTED_PLANT");
			XPAmounts.NativeFieldInfoPtr_ESCAPED_ARREST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPAmounts>.NativeClassPtr, "ESCAPED_ARREST");
			XPAmounts.NativeFieldInfoPtr_ESCAPED_WANTED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPAmounts>.NativeClassPtr, "ESCAPED_WANTED");
			XPAmounts.NativeFieldInfoPtr_ESCAPED_WANTED2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPAmounts>.NativeClassPtr, "ESCAPED_WANTED2");
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x000109DC File Offset: 0x0000EBDC
		public XPAmounts(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06001D64 RID: 7524 RVA: 0x000CBEF0 File Offset: 0x000CA0F0
		// (set) Token: 0x06001D65 RID: 7525 RVA: 0x000109E5 File Offset: 0x0000EBE5
		public unsafe static int PLAYER_COMPLETED_DEAL
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(XPAmounts.NativeFieldInfoPtr_PLAYER_COMPLETED_DEAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPAmounts.NativeFieldInfoPtr_PLAYER_COMPLETED_DEAL, (void*)(&value));
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06001D66 RID: 7526 RVA: 0x000CBF0C File Offset: 0x000CA10C
		// (set) Token: 0x06001D67 RID: 7527 RVA: 0x000109F3 File Offset: 0x0000EBF3
		public unsafe static int DEALER_COMPLETED_DEAL
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(XPAmounts.NativeFieldInfoPtr_DEALER_COMPLETED_DEAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPAmounts.NativeFieldInfoPtr_DEALER_COMPLETED_DEAL, (void*)(&value));
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06001D68 RID: 7528 RVA: 0x000CBF28 File Offset: 0x000CA128
		// (set) Token: 0x06001D69 RID: 7529 RVA: 0x00010A01 File Offset: 0x0000EC01
		public unsafe static int SUCCESSFUL_SAMPLE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(XPAmounts.NativeFieldInfoPtr_SUCCESSFUL_SAMPLE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPAmounts.NativeFieldInfoPtr_SUCCESSFUL_SAMPLE, (void*)(&value));
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06001D6A RID: 7530 RVA: 0x000CBF44 File Offset: 0x000CA144
		// (set) Token: 0x06001D6B RID: 7531 RVA: 0x00010A0F File Offset: 0x0000EC0F
		public unsafe static int HARVESTED_PLANT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(XPAmounts.NativeFieldInfoPtr_HARVESTED_PLANT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPAmounts.NativeFieldInfoPtr_HARVESTED_PLANT, (void*)(&value));
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06001D6C RID: 7532 RVA: 0x000CBF60 File Offset: 0x000CA160
		// (set) Token: 0x06001D6D RID: 7533 RVA: 0x00010A1D File Offset: 0x0000EC1D
		public unsafe static int ESCAPED_ARREST
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(XPAmounts.NativeFieldInfoPtr_ESCAPED_ARREST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPAmounts.NativeFieldInfoPtr_ESCAPED_ARREST, (void*)(&value));
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06001D6E RID: 7534 RVA: 0x000CBF7C File Offset: 0x000CA17C
		// (set) Token: 0x06001D6F RID: 7535 RVA: 0x00010A2B File Offset: 0x0000EC2B
		public unsafe static int ESCAPED_WANTED
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(XPAmounts.NativeFieldInfoPtr_ESCAPED_WANTED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPAmounts.NativeFieldInfoPtr_ESCAPED_WANTED, (void*)(&value));
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06001D70 RID: 7536 RVA: 0x000CBF98 File Offset: 0x000CA198
		// (set) Token: 0x06001D71 RID: 7537 RVA: 0x00010A39 File Offset: 0x0000EC39
		public unsafe static int ESCAPED_WANTED2
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(XPAmounts.NativeFieldInfoPtr_ESCAPED_WANTED2, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPAmounts.NativeFieldInfoPtr_ESCAPED_WANTED2, (void*)(&value));
			}
		}

		// Token: 0x04001381 RID: 4993
		private static readonly IntPtr NativeFieldInfoPtr_PLAYER_COMPLETED_DEAL;

		// Token: 0x04001382 RID: 4994
		private static readonly IntPtr NativeFieldInfoPtr_DEALER_COMPLETED_DEAL;

		// Token: 0x04001383 RID: 4995
		private static readonly IntPtr NativeFieldInfoPtr_SUCCESSFUL_SAMPLE;

		// Token: 0x04001384 RID: 4996
		private static readonly IntPtr NativeFieldInfoPtr_HARVESTED_PLANT;

		// Token: 0x04001385 RID: 4997
		private static readonly IntPtr NativeFieldInfoPtr_ESCAPED_ARREST;

		// Token: 0x04001386 RID: 4998
		private static readonly IntPtr NativeFieldInfoPtr_ESCAPED_WANTED;

		// Token: 0x04001387 RID: 4999
		private static readonly IntPtr NativeFieldInfoPtr_ESCAPED_WANTED2;
	}
}
